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

        public TransactionDetailsForm(HistoryRecord trans)
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();
            //TODO это не число подтверждений а в каком блоке включена транзакция
            Status = trans.ConfirmedInBlock == null ? "not in block" : $"in {trans.ConfirmedInBlock} block";

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
