using NBitcoin;
using System;
using System.Text;
using System.Windows.Forms;
using x42Gui.Classes;

namespace x42Gui.Forms
{
    public partial class TransactionDetailsForm : Form
    {
        string ToAddress;
        string Status;
        Money Fee;

        public TransactionDetailsForm(HistoryRecord trans, long blockCount)
        {
            InitializeComponent();

            string confirmation=String.Empty;

            StringBuilder sb = new StringBuilder();
            //TODO это не число подтверждений а в каком блоке включена транзакция
            // Status = trans.ConfirmedInBlock == null ? "not in block" : $"in {trans.ConfirmedInBlock} block";
            if (trans.ConfirmedInBlock == null)
            {
                Status = "not in block";
            }
            else
            {
                if (blockCount > 0)
                {
                    confirmation =$", {blockCount - (long)trans.ConfirmedInBlock} confirmations";
                }

                Status = $"in {trans.ConfirmedInBlock} block {confirmation}";
            }

            sb.AppendLine($"Status: {Status}");
            sb.AppendLine($"Date: {trans.Timestamp.DateTime}");
            sb.AppendLine($"Source: {trans.Type.ToString()}");
            sb.AppendLine($"Amount: {trans.Amount}");

            Fee = trans.Fee ?? Money.Zero;
            sb.AppendLine($"Fee: {Fee}");

            sb.AppendLine($"TxId: {trans.Id}");

            ToAddress = String.IsNullOrEmpty(trans.ToAddress) ? "(n/a)" : trans.ToAddress;
            sb.AppendLine($"To Address: {ToAddress}");

            sb.AppendLine($"Account: {trans.AccountName}");
            sb.AppendLine($"Wallet: {trans.WalletName}");
            textBoxDetails.Text = sb.ToString();


        }
    }
}
