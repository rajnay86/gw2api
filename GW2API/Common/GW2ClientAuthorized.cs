using RestSharp;

namespace GW2Api.Common
{
    internal class GW2ClientAuthorized : GW2Client
    {
        public GW2ClientAuthorized(int version, string apiKey) : base(version)
        {
            this.AddDefaultHeader("Authorization", $"Bearer {apiKey}");
        }
    }
}
