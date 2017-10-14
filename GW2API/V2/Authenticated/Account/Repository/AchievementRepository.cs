using System.Collections.Generic;
using GW2Api.Common;
using GW2API.V2.Authenticated.Account.Models;
using RestSharp;

namespace GW2API.V2.Authenticated.Account.Repository
{
    public class AchievementRepository
    {
        public static List<Achievement> GetAchievements(string apiKey)
        {
            var client = new GW2ClientAuthorized(2, apiKey);
            var request = new RestRequest("account/achievements");
            var response = client.Execute<List<Achievement>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                return null;
            }
            return response.Data;
        }
    }
}
