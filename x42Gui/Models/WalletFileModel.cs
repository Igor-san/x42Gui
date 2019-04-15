using System.Collections.Generic;
using Newtonsoft.Json;

namespace x42Gui.Models
{
    public class WalletFileModel
    {
        [JsonProperty(PropertyName = "walletsPath")]
        public string WalletsPath { get; set; }

        [JsonProperty(PropertyName = "walletsFiles")]
        public IEnumerable<string> WalletsFiles { get; set; }
    }
}
