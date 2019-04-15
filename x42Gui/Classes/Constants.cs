namespace x42Gui.Classes
{
    /// <summary>
    /// The type of coin, as specified in BIP44.
    /// </summary>
    /// <remarks>For more, see https://github.com/satoshilabs/slips/blob/master/slip-0044.md</remarks>
    public enum CoinType
    {
        /// <summary>
        /// Bitcoin
        /// </summary>
        Bitcoin = 0,

        /// <summary>
        /// Testnet (all coins)
        /// </summary>
        Testnet = 1,

        /// <summary>
        /// Stratis
        /// </summary>
        Stratis = 105,

        /// <summary>
        /// X42
        /// </summary>
        X42 = 424242
    }

    internal class Constants
    {
        internal const string AppName = "x42Gui";
        internal const string AppSettingsFileName = "settings.json";
        internal const string HistoryFileName = "history.json";
        internal const string AddressesFileName = "addresses.json";
        internal const string WalletFileExtension = "wallet.json";

        internal const int LastTransactionsCount = 10;//число последних транзакций для первой страницы

    }
}
