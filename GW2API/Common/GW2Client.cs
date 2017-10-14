using RestSharp;

namespace GW2API.Common
{
    internal class GW2Client : RestClient
    {
        private static readonly string baseUri = " https://api.guildwars2.com";
        internal GW2Client(int version = 2) : base($"{baseUri}/v{version}/") {}
    }
}
