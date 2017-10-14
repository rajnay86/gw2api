using RestSharp;

namespace GW2Api.Common
{
    internal class GW2Client : RestClient
    {
        private static readonly string baseUri = " https://api.guildwars2.com";
        public GW2Client(int version) : base($"{baseUri}/v{version}/") {}

        public IRestResponse Execute<T>(string resource)
        {
            var request = new RestRequest(resource);
            return Execute(request);
        }
    }
}
