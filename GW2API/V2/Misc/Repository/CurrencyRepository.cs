using System.Collections.Generic;
using GW2API.Common;
using GW2API.V2.Misc.Models;
using RestSharp;
using System.Threading.Tasks;
using GW2API.Common.Interfaces;

namespace GW2API.V2.Misc.Repository
{
    public class CurrencyRepository : IRepository<Currency, int>
    {
        private GW2Client _client;
        private readonly string _requestName = "currencies";
        public CurrencyRepository()
        {
            _client = new GW2Client();
        }

        public async Task<List<Currency>> GetAllItems()
        {
            var client = new GW2Client();
            var request = new RestRequest(_requestName);
            request.AddQueryParameter("ids", "all");
            var response = await client.ExecuteTaskAsync<List<Currency>>(request);
            return response.Data;
        }

        public async Task<List<int>> GetIds()
        {
            var client = new GW2Client();
            var request = new RestRequest(_requestName);
            var response = await client.ExecuteTaskAsync<List<int>>(request);
            return response.Data;

        }

        public async Task<List<Currency>> GetMultipleItems(List<int> ids)
        {
            var client = new GW2Client();
            var request = new RestRequest(_requestName);
            request.AddQueryParameter("ids", string.Join(",", ids));
            var response = await client.ExecuteTaskAsync<List<Currency>>(request);
            return response.Data;
        }

        public async Task<Currency> GetSingleItem(int id)
        {
            var client = new GW2Client();
            var request = new RestRequest(_requestName);
            request.AddQueryParameter("ids", id.ToString());
            var response = await client.ExecuteTaskAsync<Currency>(request);
            return response.Data;
        }
    }
}
