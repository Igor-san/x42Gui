using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using x42Gui.Models;
using NBitcoin;
using x42Gui.Classes;

namespace x42Gui.UserControls
{
    public partial class OverviewPage : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        public OverviewPage()
        {
            InitializeComponent();

        }

        private void StatusMessage(string msg)
        {
            MainForm.CurrentMainForm.StatusMessage("[SendView] " + msg);
        }

        private void ErrorMessage(string msg)
        {
            MainForm.CurrentMainForm.ErrorMessage("[SendView] " + msg);
        }

        public void SetInfo(List<WalletBalanceModel> balances)
        {
            try
            {
                Money amountConfirmed = 0;
                Money amountUnconfirmed = 0;
                Money spendableAmount = 0;

                foreach (var balance in balances)
                {
                    foreach (var item in balance.AccountsBalances)
                    {
                        spendableAmount += item.SpendableAmount;
                        amountConfirmed += item.AmountConfirmed;
                        amountUnconfirmed += item.AmountUnconfirmed;

                    }
                }

                keyValueViewSpendable.SetKeyValue("Spendable", spendableAmount.ToString());
                keyValueViewStake.SetKeyValue("Stake", (amountConfirmed - spendableAmount + amountUnconfirmed).ToString());
                keyValueViewUnconfirmed.SetKeyValue("Unconfirmed", amountUnconfirmed.ToString());
                keyValueViewConfirmed.SetKeyValue("Confirmed", amountConfirmed.ToString());
                keyValueViewTotal.SetKeyValue("Total", (amountConfirmed + amountUnconfirmed).ToString());
            }
            catch (Exception ex)
            {
                ErrorMessage("SetInfo: " + ex.Message);
            }
        }

        private List<Trans> tasks;

        internal void ShowLastTransactions()
        {
            if (Common.History == null)
                return;

            tasks = new List<Trans>();

            foreach (var pairs in Common.History)
            {
                foreach (var item in pairs.AccountsHistoryModel)
                {
                    foreach (var trx in item.TransactionsHistory.Take(Constants.LastTransactionsCount)) 
                    {
                        string description = $"{pairs.Name}:{item.Name}";
                        string icon = "tx_mined";
                        if (trx.Type== TransactionItemType.Received)
                        {
                            icon = "tx_input";
                           }
                        else if (trx.Type == TransactionItemType.Send)
                        {
                            icon = "tx_output";
                        }

                        tasks.Add(new Trans(icon, trx.Timestamp.ToString(), description, trx.Amount,trx.Id));
                    }
                }

            }

            if (tasks!=null)
                InitializeObjectListView();
        }

        public void InitializeObjectListView()
        {
            // Suppress the string contents of the first column since we are going to use
            // a decoration to draw it.
            this.olvColumnTitle.AspectToStringConverter = delegate (object x) {
                return "";
            };
            this.objectListView1.SetObjects(this.tasks);
        }

        private void objectListView1_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Trans task = (Trans)e.Model;
                NamedDescriptionDecoration decoration = new NamedDescriptionDecoration();
                decoration.ImageList = this.imageListLarge;
                decoration.Title = task.Title;
                decoration.ImageName = task.FeatureIcon;
                decoration.Description = task.Description;
                e.SubItem.Decoration = decoration;
            }
        }
    }

    public class Trans
    {
        public Trans(string featureIcon, string title, string description, Money amount, uint256 txId=null)
        {
            FeatureIcon = featureIcon;
            Title = title;
            Description = description;
            Amount = amount;
            TxId = txId;
        }

        public string FeatureIcon;
        public string Title;
        public string Description;
        public Money Amount;
        public uint256 TxId;
    }

    public class NamedDescriptionDecoration : BrightIdeasSoftware.AbstractDecoration
    {
        public ImageList ImageList;
        public string ImageName;
        public string Title;
        public string Description;

        public Font TitleFont = new Font("Segoe UI", 9, FontStyle.Bold);
        public Color TitleColor = Color.FromArgb(255, 32, 32, 32);
        public Font DescripionFont = new Font("Segoe UI", 9);
        public Color DescriptionColor = Color.FromArgb(255, 96, 96, 96);
        public Size CellPadding = new Size(0, 0);
        public override void Draw(BrightIdeasSoftware.ObjectListView olv, Graphics g, Rectangle r)
        {
            Rectangle cellBounds = this.CellBounds;
            cellBounds.Inflate(-this.CellPadding.Width, -this.CellPadding.Height);
            Rectangle textBounds = cellBounds;

            if (this.ImageList != null && !String.IsNullOrEmpty(this.ImageName))
            {
                g.DrawImage(this.ImageList.Images[this.ImageName], cellBounds.Location);
                textBounds.X += this.ImageList.ImageSize.Width;
                textBounds.Width -= this.ImageList.ImageSize.Width;
            }

            //g.DrawRectangle(Pens.Red, textBounds);

            // Draw the title
            using (StringFormat fmt = new StringFormat(StringFormatFlags.NoWrap))
            {
                fmt.Trimming = StringTrimming.EllipsisCharacter;
                fmt.Alignment = StringAlignment.Near;
                fmt.LineAlignment = StringAlignment.Near;
                using (SolidBrush b = new SolidBrush(this.TitleColor))
                {
                    g.DrawString(this.Title, this.TitleFont, b, textBounds, fmt);
                }
                // Draw the description
                SizeF size = g.MeasureString(this.Title, this.TitleFont, (int)textBounds.Width, fmt);
                textBounds.Y += (int)size.Height;
                textBounds.Height -= (int)size.Height;
            }

            // Draw the description
            using (StringFormat fmt2 = new StringFormat())
            {
                fmt2.Trimming = StringTrimming.EllipsisCharacter;
                using (SolidBrush b = new SolidBrush(this.DescriptionColor))
                {
                    g.DrawString(this.Description, this.DescripionFont, b, textBounds, fmt2);
                }
            }
        }
  
    }
}
