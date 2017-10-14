using System.Collections.Generic;
using GW2Api.Common;
using GW2Api.V2.Misc.Models;
using RestSharp;

namespace GW2Api.V2.Misc.Repository
{
    public class CurrencyRepository
    {
        public static List<Currency> GetCurrencies()
        {
            var client = new GW2Client(2);
            var request = new RestRequest("currencies");
            var response = client.Execute<List<int>>(request);
            request = new RestRequest("currencies");
            request.AddQueryParameter("ids", string.Join(",", response.Data));
            var currencies = client.Execute<List<Currency>>(request);
            return currencies.Data;
        }
    }
}
