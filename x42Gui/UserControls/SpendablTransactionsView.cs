using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using x42Gui.Classes;
using NBitcoin;
using x42Gui.Models;
using BrightIdeasSoftware;

namespace x42Gui.UserControls
{
    public partial class SpendablTransactionsView : UserControl
    {

        [Description("Показывать командную панель"), Category("Behavior")]
        public bool CommandPanelVisible
        {
            get { return panelBottom.Visible; }
            set { panelBottom.Visible = value; }
        }

        public List<SpendableTransactions> SelectedTransactions { get; private set; }

        public string LastError { get; private set; }

        public string SelectedWallet { get; private set; }
        public string SelectedAccount { get; private set; }

        public event EventHandler OkButtonClick;
        public event EventHandler CancelButtonClick;
        public event EventHandler SelectionChanged;

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        private void ErrorMessage(string msg)
        {
            LastError = msg;
        }

        public SpendablTransactionsView()
        {
            InitializeComponent();

            if ((LicenseManager.UsageMode == LicenseUsageMode.Designtime))
                return;

            labelSeveralAccountChecked.Visible = false;

            PrepareTreeListView();

        }

        private void PrepareTreeListView()
        {
            try
            {
                this.treeListView1.CheckStateGetter = delegate (object obj)
                {
                    if (obj is Wallet)
                    {
                        return ((Wallet)obj).Checked;
                    }
                    else if (obj is Account)
                    {
                        return ((Account)obj).Checked;
                    }
                    else if (obj is Address)
                    {
                        return ((Address)obj).Checked;
                    }
                    else
                    {
                        if (((SpendableTransactions)obj).Checked)
                            return CheckState.Checked;
                        else
                            return CheckState.Unchecked;
                    }

                };

                this.treeListView1.CheckStatePutter = delegate (object obj, CheckState newValue)
                {
                    this.SelectionChanged?.Invoke(this, new EventArgs());

                    if (obj is Wallet)
                    {
                        foreach (var account in ((Wallet)obj).Accounts)
                        {
                            foreach (var address in account.Addresses)
                            {
                                foreach (var item in address.SpendableTransactionsForAddress)
                                {
                                    if (newValue == CheckState.Indeterminate)
                                        continue;
                                    else if (newValue == CheckState.Checked)
                                        item.Checked = true;
                                    else
                                        item.Checked = false;
                                }
                            }
                        }
                    }
                    else if (obj is Account)
                    {
                        foreach (var address in ((Account)obj).Addresses)
                        {
                            foreach (var item in address.SpendableTransactionsForAddress)
                            {
                                if (newValue == CheckState.Indeterminate)
                                    continue;
                                else if (newValue == CheckState.Checked)
                                    item.Checked = true;
                                else
                                    item.Checked = false;
                            }
                        }
                    }
                    else if (obj is Address)
                    {
                        foreach (var item in ((Address)obj).SpendableTransactionsForAddress)
                        {
                            if (newValue == CheckState.Checked)
                                item.Checked = true;
                            else if (newValue == CheckState.Unchecked)
                                item.Checked = false;
                            else
                            {
                                ;//nothing
                            }
                        }
                        this.treeListView1.RefreshObject(this.treeListView1.GetParent(obj));
                    }
                    else
                    {
                        ((SpendableTransactions)obj).Checked = (newValue == CheckState.Checked) ? true : false;

                        this.treeListView1.RefreshObject(this.treeListView1.GetParent(this.treeListView1.GetParent(obj)));
                    }

                    this.treeListView1.RefreshObject(obj); //обновить графику
                    //пересчитать сумму выбранных входов

                    int accountChecked = SpendableTransactions.Wallets.Sum(_ => _.AccountChecked);
                    if (accountChecked > 1)
                    {
                        labelSeveralAccountChecked.Visible = true;
                    }
                    else
                    {
                        labelSeveralAccountChecked.Visible = false;
                    }

                    (int count, Money amount) = SpendableTransactions.SelectedAmount;
                    labelSelectedTransactions.Text = $"Выбрано {count} входов на сумму {amount} в {accountChecked} аккаунтах";
                    //тут же определить если выбрано несколько аккаунтов

                    return newValue; // return the value that you want the control to use
                };

                // CanExpandGetter is called often!It must be fast.
                this.treeListView1.CanExpandGetter = delegate (Object obj)
                {
                    return (obj is Wallet) || (obj is Account) || (obj is Address);
                };

                this.treeListView1.ChildrenGetter = delegate (Object obj)
                {
                    if (obj is Wallet)
                    {
                        return ((Wallet)obj).Accounts;
                    }
                    if (obj is Account)
                    {
                        return ((Account)obj).Addresses;
                    }
                    if (obj is Address)
                    {
                        return ((Address)obj).SpendableTransactionsForAddress;
                    }

                    throw new ArgumentException("Should be Wallet, Account or Address");
                };

                this.olvColumnTitle.ImageGetter = delegate (Object obj)
                {

                    if (obj is Wallet)
                        return "wallet-icon2.png";
                    else if (obj is Account)
                        return "male24.png";
                    else if (obj is Address)
                        return "mail.png";
                    else
                        return "tx_inout.png";

                };

            }
            catch (Exception ex)
            {
                ErrorMessage("PrepareTreeListView: " + ex.Message);
            }

        }

        private void treeListView1_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) //confirmations and date
            {
                if (e.Model is Wallet || e.Model is Account || e.Model is Address)
                {
                    e.SubItem.Text = "";
                }
            }
        }

        public async void GetSpendableTransactions()
        {
            if (Common.Purses == null)
                return;

            labelSelectedTransactions.Text = "Загружаю даные";
            int minConfirmations = 0;

            SpendableTransactions.ClearAll();

            var client = new ApiClient();

            foreach (var purse in Common.Purses)
            {
                Wallet wallet = new Wallet(purse.Key);

                foreach (var accountName in purse.Value)
                {
                    Account account = new Account(accountName);
                    SpendableTransactionsModel result = await client.GetSpendableTransactions(purse.Key, accountName, minConfirmations);

                    if (result != null)
                    {
                        account.AddSpendableTransactions(result.SpendableTransactions);
                    }
                    else
                    {
                        ErrorMessage("Error GetSpendableTransactions: " + client.Error);
                        return;
                    }

                    wallet.Accounts.Add(account);
                    wallet.Amount += account.Amount;

                }

                SpendableTransactions.Wallets.Add(wallet);
            }


            if (SpendableTransactions.Wallets != null)
            {
                treeListView1.SetObjects(SpendableTransactions.Wallets);
            }

            labelSelectedTransactions.Text = "";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetSpendableTransactions();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SelectedWallet = SelectedAccount = null;
            SelectedTransactions = null;
            if (SpendableTransactions.Wallets.Sum(_ => _.AccountChecked) == 1) //если только 1 аккаунт в одном кошельке выбран вернем результат
            {
                var wallet = SpendableTransactions.Wallets.Where(x => x.Checked != CheckState.Unchecked).FirstOrDefault();
                SelectedWallet = wallet.Title;
                SelectedAccount = wallet.Accounts.Where(x => x.Checked != CheckState.Unchecked).Select(x => x.Title).FirstOrDefault();
                SelectedTransactions = SpendableTransactions.Wallets.SelectMany(x => x.SelectedTransactions).ToList();
            }

            this.OkButtonClick?.Invoke(this, e);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.CancelButtonClick?.Invoke(this, e);
        }

        private void treeListView1_CellRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            e.MenuStrip = this.selectMenuStrip(e.Model, e.Column);
        }

        private ContextMenuStrip selectMenuStrip(object model, OLVColumn column)
        {
            if (model is Address)
            {
                toolStripMenuItemCopy.Tag = ((Address)model).Title;
                toolStripMenuItemCopy.Text = "Copy Address " + ((Address)model).Title;
                return contextMenuStripCopy;
            }
            if (model is SpendableTransactions)
            {
                toolStripMenuItemCopy.Tag = ((SpendableTransactions)model).Title;
                toolStripMenuItemCopy.Text = "Copy Tx " + ((SpendableTransactions)model).Title;
                return contextMenuStripCopy;
            }
            return null;
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(toolStripMenuItemCopy.Tag.ToString(), TextDataFormat.Text);
            }
            catch
            {

            }
        }


    }

}
