using MyProject.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using x42Gui.Classes;
using x42Gui.Forms;
using x42Gui.Models;

namespace x42Gui
{

    public partial class MainForm : Form
    {

        internal static MainForm CurrentMainForm;

        public MainForm()
        {
            CurrentMainForm = this;

            var fileName = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Constants.AppSettingsFileName);
            Common.CurrentSettings = UserSettings.Load(fileName);

            InitializeComponent();

        }

        internal void StatusMessage(string msg)
        {
            statusMessagePanel.StatusMessage(msg, MessagesTypes.Normal);
        }
        internal void ErrorMessage(string msg)
        {
            statusMessagePanel.StatusMessage(msg, MessagesTypes.Error);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {

                statusMessagePanel.SetCollapsed(true);

                tabControlMain.Appearance = TabAppearance.FlatButtons;
                tabControlMain.ItemSize = new Size(0, 1);
                tabControlMain.SizeMode = TabSizeMode.Fixed;

                SettingsChanged();

                tabControlMain.SelectedTab = tabPageOverview;
            }
            catch(Exception ex)
            {
                ErrorMessage("FormMain_Load: "+ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.ShowDialog();
        }

        private async void GetOverviewInfo()
        {
            var ok = await historyView1.GetHistory(); //вначале получим все транзакции по АПИ

            if (!ok)//ну тогда попробуем загрузить из файла
            {
                historyView1.LoadHistoryFromFile();
            }

            ok = await receiveView1.GetAddresses(); //вначале получим все по АПИ

            if (!ok)//ну тогда попробуем загрузить из файла
            {
                receiveView1.LoadAddressesFromFile();
            }

            overviewPage1.ShowLastTransactions(); //а уж потом отобразим последние

            if (Common.Purses == null)
                return;

            List<WalletBalanceModel> balances = new List<WalletBalanceModel>();

            ApiClient client = new ApiClient();
            foreach (var purse in Common.Purses)
            {
                var balance = await client.GetWalletBalance(purse.Key);
                if (balance != null)
                {
                    balance.WalletName = purse.Key;
                    balances.Add(balance);
                }
                else
                {
                    ErrorMessage(client.Error);
                }
            }

            overviewPage1.SetInfo(balances);

        }

        private void buttonOverview_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Button)sender);
            GetOverviewInfo();
            tabControlMain.SelectedTab = tabPageOverview;

        }

        private void SetSelectedTab(Button button)
        {
            buttonRecieve.Enabled = true;
            buttonSend.Enabled = true;
            buttonSpendableTransactions.Enabled = true;
            buttonOverview.Enabled = true;
            buttonHistory.Enabled = true;

            button.Enabled = false;

        }

        private void buttonRecieve_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Button)sender);

            tabControlMain.SelectedTab = tabPageRecieve;

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Button)sender);

            sendView1.GetInfo();
            tabControlMain.SelectedTab = tabPageSend;

        }

        private void buttonSpendablTransactions_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Button)sender);

            tabControlMain.SelectedTab = tabPageSpendableTransactions;

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm frm = new OptionsForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Reload Net
                SettingsChanged();
            }
        }
        private async void SettingsChanged()
        {
            ClearAllTab();

            if (Common.CurrentSettings.Mainnet)
            {
                this.Text = Constants.AppName + "  Mainnet";
            }
            else
            {
                this.Text = Constants.AppName + "  Testnet";
            }
            if (Common.CurrentSettings.IsStratis)
            {
                this.Text += " STRATIS";
            }
            else
            {
                this.Text += " X42";
            }
            //при смене сети нужно получить новый список кошельков и аккаунтов
            if (!await Common.LoadLocalWallets())
            {
                ErrorMessage("Не удалось получить список кошельков:" + Common.LastError + ". Возможно АПИ недоступен. Попробуйте выполнить Refresh Net, или перезагрузить программу.");
                historyView1.LoadHistoryFromFile(); //загрузим историю из файла
                receiveView1.LoadAddressesFromFile(); //адреса из файла
                overviewPage1.ShowLastTransactions(); //а уж потом отобразим последние
            }
            else
            {
                GetOverviewInfo(); //3) загрузим общую информацию
                spendableTransactionsView1.GetSpendableTransactions(); //2)
            }
        }
        /// <summary>
        /// Очистить табы от старых записей при смене сети
        /// </summary>
        private void ClearAllTab()
        {
            overviewPage1.ClearAll();
            receiveView1.ClearAll();
            sendView1.ClearAll();
            spendableTransactionsView1.ClearAll();
            historyView1.ClearAll();

        }

        private void RefreshNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsChanged();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Common.CurrentSettings.Save();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Button)sender);

            tabControlMain.SelectedTab = tabPageHistory;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClearAllTab();
        }
    }

}
