using RestSharp;
using System.Collections.Generic;

namespace GW2API.Common
{
    internal class TokenInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<string> permissions { get; set; }
    }

    internal class GW2ClientAuthorized : GW2Client
    {
        internal GW2ClientAuthorized(string apiKey) : base()
        {
            this.AddDefaultHeader("Authorization", $"Bearer {apiKey}");
        }

        internal void CheckPermissions(PermissionValues permissionToCheck)
        {
            var request = new RestRequest("tokeninfo");
            var response = ExecuteTaskAsync<TokenInfo>(request);
            bool hasPermissions = response.Result.Data != null && response.Result.Data.permissions.Contains(permissionToCheck.ToString());
            if (!hasPermissions)
            {
                throw new InvalidKeyException(permissionToCheck);
            }
        }
    }
}
