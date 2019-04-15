using NBitcoin;
using Newtonsoft.Json;
using System.IO;
using x42Gui.Utilities.JsonConverters;

namespace x42Gui.Classes
{
    class UserSettings : AppSettings<UserSettings>
    {
        [JsonConverter(typeof(MoneyJsonConverter))]
        public Money MinTxFee { get; set; } = 0;
        public bool IsStratis { get; set; } = false;
        public bool Mainnet { get; set; } = false;
        public string MainApiUrl { get; set; } = "http://localhost:42220/api/";
        public string TestApiUrl { get; set; } = "http://localhost:42221/api/";

    }

    public class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = Constants.AppSettingsFileName;

        public void Save(string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(this));
        }

        public static void Save(T pSettings, string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(pSettings));
        }

        public static T Load(string fileName = DEFAULT_FILENAME)
        {
            T t = new T();
            if (File.Exists(fileName))
                t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
            return t;
        }

    }
}
