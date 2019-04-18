using x42Gui.Models;
using Newtonsoft.Json;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using x42Gui.Utilities.JsonErrors;
using NBitcoin;

namespace x42Gui.Classes
{
    public class ApiClient
    {
        string ApiUrl;
        public string Error { get; private set; }

        public ApiClient()
        {
            if (Common.CurrentSettings.Mainnet)
            {
                ApiUrl = Common.CurrentSettings.MainApiUrl;
            }
            else
            {
                ApiUrl = Common.CurrentSettings.TestApiUrl;
            }
        }

        private string FormatErrorModel(ErrorResponse errorResponse)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in errorResponse.Errors)
            {
                sb.AppendLine($"{item.Description}:{item.Message}");
            }
            return sb.ToString();
        }

        public async Task<WalletFileModel> GetWalletFiles()
        {
            try
            {
                Error = String.Empty;
                Url url = new Url(ApiUrl).AppendPathSegments("wallet/files");

                return await url.GetJsonAsync<WalletFileModel>();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        public async Task<AddressesModel> GetAddressesInAccount(string walletName, string accountName)
        {
            try
            {
                Error = String.Empty;
                Url url = new Url(ApiUrl).AppendPathSegments("wallet/addresses");
                url.SetQueryParam("walletName", walletName);
                url.SetQueryParam("accountName", accountName);

                return await url.GetJsonAsync<AddressesModel>();

            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }


        public async Task<IEnumerable<string>> GetAccountsInWallet(string walletName)
        {
            try
            {
                Error = String.Empty;
                Url url = new Url(ApiUrl).AppendPathSegments("wallet/accounts");
                url.SetQueryParam("walletName", walletName);

                return await url.GetJsonAsync<IEnumerable<string>>();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        internal async Task<long> GetBlockCount()
        {
            try
            {
                Error = String.Empty;
                Url url = new Url(ApiUrl).AppendPathSegments("blockstore/getblockcount");
                return await url.GetJsonAsync<long>();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return -1;
            }
        }

        internal async Task<WalletHistoryModel> GetHistory(string walletName, string accountName = null)
        {
            try
            {
                Error = String.Empty;
                Url url = new Url(ApiUrl).AppendPathSegments("wallet/history");
                url.SetQueryParam("walletName", walletName);
                if (!String.IsNullOrEmpty(accountName))
                {
                    url.SetQueryParam("accountName", accountName);
                }

                return await url.GetJsonAsync<WalletHistoryModel>();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        internal async Task<TransactionVerboseModel> GetTransaction(string trxid, bool verbose = true)
        {
            try
            {
                Error = String.Empty;
                Url url = new Url(ApiUrl).AppendPathSegments("Node/getrawtransaction");
                url.SetQueryParam("trxid", trxid);
                url.SetQueryParam("verbose", verbose);

                return await url.GetJsonAsync<TransactionVerboseModel>();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }

        }

        internal async Task<WalletBalanceModel> GetWalletBalance(string walletName)
        {
            try
            {
                Error = String.Empty;
                Url url = new Url(ApiUrl).AppendPathSegments("wallet/balance");
                url.SetQueryParam("WalletName", walletName);
                return await url.GetJsonAsync<WalletBalanceModel>();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        public async Task<bool> SendTransaction(string hex)
        {
            try
            {
                Error = String.Empty;
                Url url = new Url(ApiUrl).AppendPathSegments("wallet/send-transaction");
                await url.PostJsonAsync(new SendTransactionRequest
                {
                    Hex = hex
                }).ReceiveJson<WalletSendTransactionModel>();

                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }

        }

        /// <summary>
        /// Только для Стратиса. У х42 это GET, да и не нужно
        /// </summary>
        /// <param name="walletName"></param>
        /// <param name="accountName"></param>
        /// <param name="recipients"></param>
        /// <param name="outpoints"></param>
        /// <param name="opReturnData"></param>
        /// <param name="opReturnAmount"></param>
        /// <param name="feeType"></param>
        /// <returns></returns>
        public async Task<Money> GetEstimateFee(string walletName, string accountName, List<RecipientModel> recipients, List<OutpointRequest> outpoints = null, string opReturnData = null, string opReturnAmount = null, FeeType feeType = FeeType.Low)
        {
            try
            {
                Error = String.Empty;

                Url url = new Url(ApiUrl).AppendPathSegments("wallet/estimate-txfee");

                return await url
                    .PostJsonAsync(new TxFeeEstimateRequest
                    {
                        WalletName = walletName,
                        AccountName = accountName,
                        FeeType = feeType.ToString(),
                        ShuffleOutputs = true,
                        AllowUnconfirmed = true,
                        Recipients = recipients,
                        Outpoints = outpoints,
                        OpReturnData = opReturnData,
                        OpReturnAmount = opReturnAmount

                    })
                    .ReceiveJson<Money>();

            }
            catch (FlurlHttpException ex)
            {
                var response = ex.Call.Response;

                ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await response.Content.ReadAsStringAsync());
                if (errorResponse != null)
                {
                    Error = FormatErrorModel(errorResponse);
                }
                else
                {
                    Error = ex.Message;
                }
                return null;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }

        }

        public async Task<WalletBuildTransactionModel> BuildTransaction(string walletName, string accountName, string password, List<RecipientModel> recipients, List<OutpointRequest> outpoints = null, string opReturnData = null, string opReturnAmount = null, FeeType feeType = FeeType.Low)
        {
            try
            {
                //FeeAmount не может быть установлен одновременно с FeeType
                Error = String.Empty;

                Func<Task<WalletBuildTransactionModel>> act = async () => await new Url(ApiUrl)
                    .AppendPathSegment("wallet/build-transaction")
                    .PostJsonAsync(new BuildTransactionRequest
                    {
                        WalletName = walletName,
                        AccountName = accountName,
                        FeeType = feeType.ToString(),
                        Password = password,
                        ShuffleOutputs = true,
                        AllowUnconfirmed = true,
                        Recipients = recipients,
                        Outpoints = outpoints,
                        OpReturnData = opReturnData,
                        OpReturnAmount = opReturnAmount
                    })
                    .ReceiveJson<WalletBuildTransactionModel>();

                return await act();

            }
            catch (FlurlHttpException ex)
            {
                var response = ex.Call.Response;

                ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await response.Content.ReadAsStringAsync());
                if (errorResponse != null)
                {
                    Error = FormatErrorModel(errorResponse);
                }
                else
                {
                    Error = ex.Message;
                }
                return null;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }

        }

        public async Task<IEnumerable<string>> GetAccounts(string walletName)
        {
            try
            {
                Error = String.Empty;

                Url url = new Url(ApiUrl).AppendPathSegments("wallet/accounts");
                url.SetQueryParam("walletName", walletName);
                return await url.GetJsonAsync<IEnumerable<string>>();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }

        }
        internal async Task<SpendableTransactionsModel> GetSpendableTransactions(string walletName, string accountName, int minConfirmations)
        {
            try
            {
                Error = String.Empty;
                Url url = new Url(ApiUrl).AppendPathSegments("Wallet/spendable-transactions");
                url.SetQueryParams(new { walletName, accountName, minConfirmations });

                return await url.GetJsonAsync<SpendableTransactionsModel>();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;

            }
        }

    }
}
