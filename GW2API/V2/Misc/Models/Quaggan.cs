using Newtonsoft.Json;
namespace GW2API.V2.Misc.Models
{
    [JsonObject]
    public class Quaggan
    {
        /// <summary>
        /// The quaggan identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The URL to the quaggan image.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
