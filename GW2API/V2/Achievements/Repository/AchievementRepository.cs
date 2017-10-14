using GW2API.Common;
using GW2API.Common.Interfaces;
using GW2API.V2.Achievements.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GW2API.V2.Achievements.Repository
{
    public class AchievementRepository : ISingleItemRepository<Achievement, int>, IIdRepository<int>, IMultipleItemRepository<Achievement, int>
    {
        private GW2Client _client;
        private readonly string _requestName = "achievements";

        public AchievementRepository()
        {
            _client = new GW2Client();
        }

        public async Task<List<int>> GetIds()
        {
            var client = new GW2Client();
            var request = new RestRequest(_requestName);
            var response = await client.ExecuteTaskAsync<List<int>>(request);
            return response.Data;
        }

        public async Task<List<Achievement>> GetMultipleItems(List<int> ids)
        {
            var request = new RestRequest(_requestName, Method.GET);
            request.AddQueryParameter("id", string.Join(",", ids));
            var response = await _client.ExecuteTaskAsync<List<Achievement>>(request);
            return response.Data;
        }

        public async Task<Achievement> GetSingleItem(int id)
        {
            var client = new GW2Client();
            var request = new RestRequest(_requestName);
            request.AddQueryParameter("ids", id.ToString());
            var response = await client.ExecuteTaskAsync<Achievement>(request);
            return response.Data;
        }
    }
}
