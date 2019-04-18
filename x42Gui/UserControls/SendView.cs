using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using x42Gui.Models;
using x42Gui.Classes;
using NBitcoin;
using x42Gui.Forms;

namespace x42Gui.UserControls
{
    public partial class SendView : UserControl
    {

        List<WalletBalanceModel> Balances;

        private bool NegativeChange = false;
        private List<SpendableTransactions> SelectedTransactions;

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        public SendView()
        {
            InitializeComponent();

            panelInputsInfo.Visible = false;
            buttonSend.Enabled = false;

            if ((LicenseManager.UsageMode == LicenseUsageMode.Designtime))
                return;

        }

        private void StatusMessage(string msg)
        {
            MainForm.CurrentMainForm.StatusMessage("[SendView] " + msg);
        }

        private void ErrorMessage(string msg)
        {
            MainForm.CurrentMainForm.ErrorMessage("[SendView] " + msg);
        }

        internal void ClearAll()
        {
            labelQuantity.Text = "";
            labelChange.Text = "";
            labelTxFee.Text = "";

            labelAutomaticallySelected.Visible = true;
            SelectedTransactions = null;
            textBoxCustomChangeAddress.Clear();
            panelInputsInfo.Visible = false;

            groupBoxAccount.Enabled = true;
            comboBoxWallet.Text = "";
            comboBoxAccount.Text = "";
            comboBoxAccount.Items.Clear();
            textBoxPayTo.Clear();
            numericTextBoxAmount.Text = "0";

            buttonSend.Enabled = false;
        }



        internal async void GetInfo()
        {
            labelTxFee.Text = $"Min Fee: {Common.CurrentSettings.MinTxFee}";

            comboBoxWallet.Items.Clear();
            comboBoxAccount.Items.Clear();

            labelInfo.Text = "Balance: ";

            if (Common.Purses == null)
                return;
            Balances = new List<WalletBalanceModel>();

            ApiClient client = new ApiClient();
            foreach (var purse in Common.Purses)
            {
                comboBoxWallet.Items.Add(purse);
                var balance = await client.GetWalletBalance(purse.Key);
                if (balance != null)
                {
                    balance.WalletName = purse.Key;
                    Balances.Add(balance);
                    labelInfo.Text += ($"{purse.Key}={Money.FromUnit(balance.AccountsBalances.Sum(x => x.SpendableAmount), MoneyUnit.Satoshi)},");
                }
                else
                {
                    ErrorMessage(client.Error);
                }

            }

            comboBoxWallet.DisplayMember = "key";
            comboBoxWallet.SelectedIndex = -1;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void checkBoxCustomChangeAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomChangeAddress.Checked)
            {
                textBoxCustomChangeAddress.Enabled = true;
            }
            else
            {
                textBoxCustomChangeAddress.Enabled = false;
            }
        }



        private void buttonSelectInputs_Click(object sender, EventArgs e)
        {
            try
            {
                CoinControlForm frm = new CoinControlForm();
                DialogResult res = frm.ShowDialog();
                SelectedTransactions = frm.spendableTransactionsView1.SelectedTransactions;
                if (res == DialogResult.OK && SelectedTransactions != null)
                {
                    panelInputsInfo.Visible = true;
                    checkBoxCustomChangeAddress.Enabled = true;
                    groupBoxAccount.Enabled = false;
                    labelAutomaticallySelected.Visible = false;
                    comboBoxWallet.Text = frm.spendableTransactionsView1.SelectedWallet;
                    comboBoxAccount.Text = frm.spendableTransactionsView1.SelectedAccount;

                    labelQuantity.Text = $"Quantity: {SelectedTransactions.Count()}, Amount: {Money.FromUnit(SelectedTransactions.Sum(x => x.Amount), MoneyUnit.Satoshi)} coins";

                    CalculateChange(numericTextBoxAmount.DecimalValue);
                }
                else
                {
                    labelQuantity.Text = "";
                    panelInputsInfo.Visible = false;
                    checkBoxCustomChangeAddress.Enabled = false;
                    groupBoxAccount.Enabled = true;
                    labelAutomaticallySelected.Visible = true;
                    SelectedTransactions = null;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage("buttonSelectInputs_Click:" + ex.Message);
            }
        }


        private async Task<string> SendTransaction(string wallet, string account, string password, List<RecipientModel> recipients, List<OutpointRequest> outpoints)
        {
            ApiClient client = new ApiClient();
            var tx = await client.BuildTransaction(wallet, account, password, recipients, outpoints);
            if (tx == null)
            {
                ErrorMessage("Error BuildTransaction: " + client.Error);
                return null;
            }

            bool result = await client.SendTransaction(tx.Hex);
            if (!result)
            {
                ErrorMessage("Error SendTransaction: " + client.Error);
                return null;
            }

            return tx.TransactionId.ToString();
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {

            buttonSend.Enabled = false;

            string wallet = comboBoxWallet.Text;
            string account = comboBoxAccount.Text;

            List<RecipientModel> recipients = new List<RecipientModel>();

            Money how = Money.FromUnit(numericTextBoxAmount.DecimalValue, MoneyUnit.BTC);
            recipients.Add(new RecipientModel(textBoxPayTo.Text.Trim(), how.ToString()));

            List<OutpointRequest> outpoints = null;
            if (SelectedTransactions != null)
            {
                outpoints = new List<OutpointRequest>();

                foreach (var item in SelectedTransactions)
                {
                    outpoints.Add(new OutpointRequest(item.TxId.ToString(), item.Index));
                }

                //свой адрес для сдачи можно установить если сами выбираем входа, иначе не узнать какие выберет программа
                if (checkBoxCustomChangeAddress.Checked && !String.IsNullOrEmpty(textBoxCustomChangeAddress.Text.Trim()))
                {
                    //нужно посчитать сколько будет сдачи и, если больше 0, направить все это на адрес
                    string changeAddress = textBoxCustomChangeAddress.Text.Trim();
                    Money change = Money.FromUnit(SelectedTransactions.Sum(x => x.Amount), MoneyUnit.Satoshi) - how - Common.CurrentSettings.MinTxFee;
                    if (change > Money.Zero)
                    {
                        recipients.Add(new RecipientModel(changeAddress, change.ToString()));
                    }
                }

            }

            #region Fee - на Stratis MainNet почти тестировал!!!
            if (Common.CurrentSettings.IsStratis)
            {
                //Оценка комиссии - Для Статиса только? Но все равно комиссия посчитается автоматически так как передаю ее тип а не значение
                //х42 фии нет но для стратиса можно оценить api/wallet/estimate-txfee по POST а у х42 GET
                ApiClient client = new ApiClient();
                var fee = await client.GetEstimateFee(wallet, account, recipients, outpoints);
                if (fee == null)
                {
                    ErrorMessage("Error GetEstimateFee: " + client.Error);
                    return;
                }
                if (fee > Money.Zero) //нужно подтверждение
                {
                    if (DialogResult.Yes != MessageBox.Show($"The commission will be {fee} coins. Do you agree to pay for it?", "Commission", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                    {
                        ErrorMessage($"You refused to pay a commission in {fee}");
                        return;
                    }
                }
            }
            #endregion Fee

            //Запросим пароль
            string password;
            PasswordForm pass = new PasswordForm();
            pass.ShowDialog();
            if (DialogResult.OK == pass.DialogResult)
            {
                password = pass.Password;
            }
            else
            {
                ErrorMessage("You have not entered a password");
                return;
            }

            var result = await SendTransaction(wallet, account, password, recipients, outpoints);

            if (result != null)
            {
                MessageForm frm = new MessageForm();
                frm.InputBox("Transaction ID: ", "Transaction has been successfully sent", result);
            }
            else
            {
                MessageBox.Show("Error: see in log ", "Failed to send transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CalculateChange(decimal value)
        {
            labelChange.Text = "";
            labelChange.ForeColor = Color.Black;
            NegativeChange = false;

            Money how = Money.FromUnit(numericTextBoxAmount.DecimalValue, MoneyUnit.BTC);

            if (how <= 0)
                return;

            Money amount;
            if (SelectedTransactions != null)
            {
                amount = Money.FromUnit(SelectedTransactions.Sum(x => x.Amount), MoneyUnit.Satoshi);
            }
            else
            {
                amount = GetBalance();
                labelQuantity.Text = $"Amount: {amount} coins";
            }

            Money change = amount - how - Common.CurrentSettings.MinTxFee;
            labelChange.Text = $"Change: {change}";

            if (change < 0)
            {
                NegativeChange = true;
                labelChange.ForeColor = Color.Red;
            }

            CheckEnableSend();
        }


        private void textBoxPayTo_TextChanged(object sender, EventArgs e)
        {
            CheckEnableSend();
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateChange(numericTextBoxAmount.DecimalValue);
        }

        private void comboBoxWallet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxAccount.Items.Clear();

                var selected = (KeyValuePair<string, List<string>>)comboBoxWallet.SelectedItem;
                foreach (var item in selected.Value)
                {
                    comboBoxAccount.Items.Add(item);
                }
                comboBoxAccount.SelectedIndex = 0;

                CheckEnableSend();
            }
            catch (Exception ex)
            {
                ErrorMessage("comboBoxWallet_SelectedIndexChanged: " + ex.Message);
            }
        }
        private void comboBoxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            var balance = GetBalance();
            labelQuantity.Text = $"Amount: {balance} coins";

            CalculateChange(numericTextBoxAmount.DecimalValue);
        }

        /// <summary>
        /// получим баланс кошелька-аккаунта
        /// </summary>
        private Money GetBalance()
        {
            Money balance = Money.Zero;
            string wallet = comboBoxWallet.Text;
            string account = comboBoxAccount.Text;

            if (!String.IsNullOrEmpty(wallet) && !String.IsNullOrEmpty(account))
            {
                balance = Balances.Where(x => x.WalletName == wallet).SelectMany(x => x.AccountsBalances).Where(x => x.Name == account).Sum(x => x.SpendableAmount);
            }

            return balance;
        }

        private void CheckEnableSend()
        {
            if (!NegativeChange && !String.IsNullOrEmpty(comboBoxWallet.Text) &&
                !String.IsNullOrEmpty(comboBoxAccount.Text) &&
                !String.IsNullOrEmpty(textBoxPayTo.Text))
            {
                buttonSend.Enabled = true;
            }
            else
            {
                buttonSend.Enabled = false;
            }
        }

        private void numericTextBoxAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateChange(numericTextBoxAmount.DecimalValue);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            GetInfo();
        }
    }
}
