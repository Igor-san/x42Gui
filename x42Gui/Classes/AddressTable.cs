namespace x42Gui.Classes
{
    public class AddressRecord
    {
        public string WalletName { get; set; }

        public string AccountName { get; set; }

        public string Address { get; set; }

        public bool IsUsed { get; set; }

        public bool IsChange { get; set; }

        public AddressRecord(string WalletName, string AccountName, string Address, bool IsUsed, bool IsChange)
        {
            this.WalletName = WalletName;
            this.AccountName = AccountName;
            this.Address = Address;
            this.IsUsed = IsUsed;
            this.IsChange = IsChange;
        }
    }
}
