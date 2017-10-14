using Newtonsoft.Json;

namespace GW2API.V2.Misc.Models
{
    [JsonObject]
    public class Currency
    {
        /// <summary>
        /// The currency's ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The currency's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description of the currency.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A number that can be used to sort the list of currencies when ordered from least to greatest.
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// A URL to an icon for the currency.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}