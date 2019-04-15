using NBitcoin;
using System;
using x42Gui.Models;

namespace x42Gui.Classes
{
    public class HistoryRecord
    {
        public string WalletName { get; set; }

        public string AccountName { get; set; }

        public TransactionItemType Type { get; set; }

        public string ToAddress { get; set; }

        public uint256 Id { get; set; }

        public Money Amount { get; set; }

        public Money Fee { get; set; }

        public int? ConfirmedInBlock { get; set; }

        public DateTimeOffset Timestamp { get; set; }

        public HistoryRecord(string WalletName, string AccountName, TransactionItemType Type, string ToAddress,
            uint256 Id, Money Amount, Money Fee, int? ConfirmedInBlock, DateTimeOffset Timestamp)
        {
            this.WalletName = WalletName;
            this.AccountName = AccountName;
            this.Type = Type;
            this.ToAddress = ToAddress;
            this.Id = Id;
            this.Amount = Amount;
            this.Fee = Fee;
            this.ConfirmedInBlock = ConfirmedInBlock;
            this.Timestamp = Timestamp;
        }
    }
}
