using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using x42Gui.Classes;
using x42Gui.Models;
using x42Gui.Utilities;
using System.IO;
using BrightIdeasSoftware;

namespace x42Gui.UserControls
{
    public partial class ReceiveView : UserControl
    {
        private readonly FileStorage<List<AddressesModel>> fileStorage;

        string AddressesFile;

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        private void StatusMessage(string msg)
        {
            MainForm.CurrentMainForm.StatusMessage("[ReceiveView] " + msg);
        }

        private void ErrorMessage(string msg)
        {
            MainForm.CurrentMainForm.ErrorMessage("[ReceiveView] " + msg);
        }

        public ReceiveView()
        {
            InitializeComponent();

            InitializeListView();

            this.AddressesFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Constants.AddressesFileName);
            this.fileStorage = new FileStorage<List<AddressesModel>>(this.AddressesFile);
        }


        private void InitializeListView()
        {
            ;
        }

        private void AddressesModelToAddressTable()
        {

            List<AddressRecord> table = new List<AddressRecord>();

            foreach (var wallet in Common.Addresses)
            {
                foreach (var account in wallet.Addresses)
                {
                 table.Add(new AddressRecord(wallet.WalletName, wallet.AccountName, account.Address, account.IsUsed, account.IsChange));
                }
                
            }

            objectListView1.SetObjects(table);
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await GetAddresses();
        }

        internal async Task<bool> GetAddresses()
        {
            try
            {
                if (Common.Purses == null)
                    return false;

                ApiClient client = new ApiClient();
                Common.Addresses = new List<AddressesModel>();

                foreach (var wallet in Common.Purses)
                {
                    foreach (var account in wallet.Value)
                    {
                        var addr = await client.GetAddressesInAccount(wallet.Key,account);

                        if (addr!=null && addr.Addresses!=null)
                        {
                            Common.Addresses.Add(new AddressesModel(wallet.Key, account, addr.Addresses));
                        }
                        else
                        {
                            ErrorMessage(client.Error);
                            return false;
                        }
                    }

                }

                this.fileStorage.SaveToFile(Common.Addresses, this.AddressesFile);

                labelNotActual.Visible = false;
                AddressesModelToAddressTable();

                return true;

            }
            catch (Exception ex)
            {
                ErrorMessage("GetAddresses:" + ex.Message);
                return false;
            }

        }

        internal void LoadAddressesFromFile()
        {
            labelNotActual.Visible = true;
            if (File.Exists(this.AddressesFile))
            {
                Common.Addresses = this.fileStorage.LoadByFileName(this.AddressesFile);
                AddressesModelToAddressTable();
            }

        }

        private void objectListView1_CellRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            e.MenuStrip = this.selectMenuStrip(e.Model, e.Column);
        }

        private ContextMenuStrip selectMenuStrip(object model, OLVColumn column)
        {
            if (model is AddressRecord)
            {
                toolStripMenuItemCopy.Tag = ((AddressRecord)model).Address;
                toolStripMenuItemCopy.Text = "Copy Address " + ((AddressRecord)model).Address;
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
