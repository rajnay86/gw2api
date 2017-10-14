using System.Collections.Generic;
using GW2Api.Common;
using GW2Api.V2.Misc.Models;
using RestSharp;

namespace GW2Api.V2.Misc.Repository
{
    public class QuagganRepository
    {
        public static List<string> GetQuaggans()
        {
            var client = new GW2Client(2);
            var request = new RestRequest("quaggans", Method.GET);
            var response = client.Execute<List<string>>(request);
            return response.Data;
        }

        public static Quaggan GetQuaggan(string id)
        {
            var client = new GW2Client(2);
            var request = new RestRequest("quaggans/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var quaggan = client.Execute<Quaggan>(request);
            return quaggan.Data;
        }
    }
}
