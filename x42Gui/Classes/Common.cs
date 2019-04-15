using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x42Gui.Models;

namespace x42Gui.Classes
{
    public class Common
    {
        internal static UserSettings CurrentSettings = null;

        internal static string LastError;

        /// <summary>
        /// Список кошельков с их аккаунтами
        /// </summary>
        internal static Dictionary<string, List<string>> Purses = null;
        /// <summary>
        /// История транзакций по всем кошелькам и аккаунтам
        /// </summary>
        internal static List<WalletHistoryModel> History = null;

        /// <summary>
        /// Список адресов по всем кошелькам и аккаунтам
        /// </summary>
        internal static List<AddressesModel> Addresses = null;

        internal static async Task<bool> LoadLocalWallets()
        {
            LastError = String.Empty;

            Purses = new Dictionary<string, List<string>>();

            ApiClient client = new ApiClient();

            var wallets = await client.GetWalletFiles();

            if (wallets == null)
            {
                LastError = client.Error;
                Purses = null;
                return false;
            }

            foreach (var item in wallets.WalletsFiles)
            {
                string walletName = item.Remove(item.Length - Constants.WalletFileExtension.Length - 1);
                var accounts = await client.GetAccountsInWallet(walletName);
                if (accounts == null)
                {
                    LastError = client.Error;
                    Purses = null;
                    return false;
                }
                Purses[walletName] = accounts.ToList();
            }

            return true;
        }

    }

}
