using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using x42Gui.Classes;
using x42Gui.Models;
using x42Gui.Utilities;
using System.IO;
using x42Gui.Forms;

namespace x42Gui.UserControls
{
    public partial class HistoryView : UserControl
    {
        private readonly FileStorage<List<WalletHistoryModel>> fileStorage;

        string WalletHistoryFile;

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        public HistoryView()
        {
            InitializeComponent();

            InitializeListView();

            this.WalletHistoryFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Constants.HistoryFileName);
            this.fileStorage = new FileStorage<List<WalletHistoryModel>>(this.WalletHistoryFile);
        }

        private void StatusMessage(string msg)
        {
            MainForm.CurrentMainForm.StatusMessage("[HistoryView] " + msg);
        }

        private void ErrorMessage(string msg)
        {
            MainForm.CurrentMainForm.ErrorMessage("[HistoryView] " + msg);
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await GetHistory();
        }

        internal async Task<bool> GetHistory()
        {
            try
            {
                if (Common.Purses == null)
                    return false;

                ApiClient client = new ApiClient();


                Common.History = new List<WalletHistoryModel>();

                foreach (var purse in Common.Purses)
                {
                    var his = await client.GetHistory(purse.Key);
                    if (his != null && his.AccountsHistoryModel != null)
                    {
                        his.Name = purse.Key;
                        Common.History.Add(his);
                    }
                    else
                    {
                        ErrorMessage(client.Error);
                        return false;
                    }
                }

                this.fileStorage.SaveToFile(Common.History, this.WalletHistoryFile);

                labelNotActual.Visible = false;
                WalletHistoryModelToHistoryTable();

                return true;

            }
            catch (Exception ex)
            {
                ErrorMessage("GetHistory:" + ex.Message);
                return false;
            }

        }

        private void WalletHistoryModelToHistoryTable()
        {

            List<HistoryRecord> table = new List<HistoryRecord>();

            foreach (var wallet in Common.History)
            {
                foreach (var account in wallet.AccountsHistoryModel)
                {
                    foreach (var trx in account.TransactionsHistory)
                    {
                        string toAddress = trx.ToAddress;
                        if (trx.Payments != null && trx.Payments.Count > 0)
                        {
                            var addr = trx.Payments.Select(x => x.DestinationAddress);
                            if (addr != null && addr.Count() > 0)
                            {
                                toAddress = String.Join(" ; ", addr.ToArray());
                            }
                        }

                        table.Add(new HistoryRecord(wallet.Name, account.Name, trx.Type, toAddress, trx.Id, trx.Amount,
                            trx.Fee, trx.ConfirmedInBlock, trx.Timestamp));
                    }
                }

            }

            objectListView1.SetObjects(table);
        }

        internal void LoadHistoryFromFile()
        {
            labelNotActual.Visible = true;
            if (File.Exists(this.WalletHistoryFile))
            {
                Common.History = this.fileStorage.LoadByFileName(this.WalletHistoryFile);
                WalletHistoryModelToHistoryTable();
            }

        }

        private void InitializeListView()
        {

            this.olvColumnTimestamp.GroupKeyGetter = delegate (object rowObject)
            {
                HistoryRecord record = (HistoryRecord)rowObject;
                return new DateTime(record.Timestamp.Year, record.Timestamp.Month, record.Timestamp.Day, 0, 0, 0);

            };

            this.olvColumnTimestamp.GroupKeyToTitleConverter = delegate (object groupKey)
            {
                return ((DateTime)groupKey).ToString("dd MMMM yyyy");
            };


        }

        private void objectListView1_ItemActivate(object sender, EventArgs e)
        {
            var item = objectListView1.GetItem(objectListView1.SelectedIndex).RowObject;
            if (item is HistoryRecord)
            {
                TransactionDetailsForm frm = new TransactionDetailsForm((HistoryRecord)item);
                frm.ShowDialog();

            }
        }
    }
}
