using System.Collections.Generic;
using GW2API.Common;
using GW2API.Common.Interfaces;
using GW2API.V2.Misc.Models;
using RestSharp;
using System.Threading.Tasks;

namespace GW2API.V2.Misc.Repository
{
    public class QuagganRepository : IRepository<Quaggan, string>
    {
        private GW2Client _client;
        private readonly string _requestName = "quaggans";
        public QuagganRepository()
        {
            _client = new GW2Client();
        }

        public async Task<Quaggan> GetSingleItem(string id)
        {
            var request = new RestRequest(_requestName, Method.GET);
            request.AddQueryParameter("id", id);
            var quaggan = await _client.ExecuteTaskAsync<Quaggan>(request);
            return quaggan.Data;
        }

        public async Task<List<Quaggan>> GetAllItems()
        {
            var request = new RestRequest(_requestName, Method.GET);
            request.AddQueryParameter("id", "all");
            var response = await _client.ExecuteTaskAsync<List<Quaggan>>(request);
            return response.Data;
        }

        public async Task<List<string>> GetIds()
        {
            var request = new RestRequest(_requestName, Method.GET);
            var quaggan = await _client.ExecuteTaskAsync<List<string>>(request);
            return quaggan.Data;
        }

        public async Task<List<Quaggan>> GetMultipleItems(List<string> ids)
        {
            var client = new GW2Client();
            var request = new RestRequest(_requestName);
            request.AddQueryParameter("ids", string.Join(",", ids));
            var response = await client.ExecuteTaskAsync<List<Quaggan>>(request);
            return response.Data;
        }
    }
}
