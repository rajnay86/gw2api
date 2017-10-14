using System.Collections.Generic;
using GW2API.V2.Authenticated.Account.Models;
using RestSharp;
using GW2API.Common;
using System.Threading.Tasks;
using GW2API.Common.Interfaces;

namespace GW2API.V2.Authenticated.Account.Repository
{
    public class AccountAchievementRepository : IAllItemRepository<AccountAchievement>
    {
        private readonly string _requestName = "account/achievements";
        private GW2ClientAuthorized _client;
        public AccountAchievementRepository(string apiKey)
        {
            _client = new GW2ClientAuthorized(apiKey);
            _client.CheckPermissions(PermissionValues.account);
        }

        public async Task<List<AccountAchievement>> GetAllItems()
        {
            var request = new RestRequest(_requestName);
            var response = await _client.ExecuteTaskAsync<List<AccountAchievement>>(request);
            return response.Data;
        }
    }
}
