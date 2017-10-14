using System.Collections.Generic;
using System.Linq;
using GW2Api.Common;
using GW2Api.V2.Authenticated.Account.Models;
using GW2Api.V2.Misc.Repository;
using RestSharp;

namespace GW2Api.V2.Authenticated.Account.Repository
{
    public class WalletRepository
    {
        private static List<Wallet> GetWallet(string apiKey)
        {
            var client = new GW2ClientAuthorized(2, apiKey);
            var request = new RestRequest("account/wallet");
            var response = client.Execute<List<Wallet>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                return null;
            }
            return response.Data;
        }

        public static Dictionary<string, int> GetWalletWithNames(string apiKey)
        {
            var wallet = GetWallet(apiKey);
            if (wallet == null)
            {
                return null;
            }
            var currencies = CurrencyRepository.GetCurrencies();
            var walletWithNames = currencies.Zip(wallet, (k, v) => new { k.name, v.value }).ToDictionary(x => x.name, x=> x.value);
            return walletWithNames;
        }

        public static int[] GetCoin(string apiKey)
        {
            int[] money = new int[3];
            var wallet = GetWallet(apiKey).FirstOrDefault(w => w.id == 1);
            if(wallet == null)
            {
                return null;
            }
            var copper = wallet.value;
            money[0] = copper / 10000;
            copper = copper % 10000;
            money[1] = copper / 100;
            copper = copper % 100;
            money[2] = copper;
            return money;
        }
    }
}
