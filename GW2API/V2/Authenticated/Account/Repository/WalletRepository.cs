using System.Collections.Generic;
using GW2API.Common;
using GW2API.Common.Interfaces;
using GW2API.V2.Authenticated.Account.Models;
using RestSharp;
using System.Threading.Tasks;

namespace GW2API.V2.Authenticated.Account.Repository
{
    public class WalletRepository : IAllItemRepository<Wallet>
    {
        private readonly string _requestName = "account/wallet";
        private GW2ClientAuthorized _client;
        public WalletRepository(string apiKey)
        {
            _client = new GW2ClientAuthorized(apiKey);
            _client.CheckPermissions(PermissionValues.wallet);
        }

        public async Task<List<Wallet>> GetAllItems()
        {
            var request = new RestRequest(_requestName);
            var response = await _client.ExecuteTaskAsync<List<Wallet>>(request);
            return response.Data;
        }
    }
}
