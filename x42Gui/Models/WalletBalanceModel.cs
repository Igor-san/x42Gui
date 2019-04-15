using System.Collections.Generic;
using x42Gui.Classes;
using NBitcoin;
using Newtonsoft.Json;

namespace x42Gui.Models
{
    public class WalletBalanceModel
    {
        public WalletBalanceModel()
        {
            this.AccountsBalances = new List<AccountBalanceModel>();
        }

        [JsonIgnore]
        public string WalletName { get; set; }

        [JsonProperty(PropertyName = "balances")]
        public List<AccountBalanceModel> AccountsBalances { get; set; }
    }

    public class AccountBalanceModel
    {
        [JsonProperty(PropertyName = "accountName")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "accountHdPath")]
        public string HdPath { get; set; }

        [JsonProperty(PropertyName = "coinType")]
        public CoinType CoinType { get; set; }

        [JsonProperty(PropertyName = "amountConfirmed")]
        public Money AmountConfirmed { get; set; }

        [JsonProperty(PropertyName = "amountUnconfirmed")]
        public Money AmountUnconfirmed { get; set; }

        [JsonProperty(PropertyName = "spendableAmount")]
        public Money SpendableAmount { get; set; }
    }
}
