using Newtonsoft.Json;
using System.Collections.Generic;

namespace GW2API.V2.Authenticated.Account.Models
{
    public class AccountAchievement
    {
        /// <summary>
        /// The achievement id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The player's current progress towards the achievement.
        /// </summary>
        [JsonProperty("current")]
        public int Current { get; set; }

        /// <summary>
        /// The amount needed to complete the achievement. Most WvW achievements have this set to -1.
        /// </summary>
        [JsonProperty("max")]
        public int Max { get; set; }

        /// <summary>
        /// Whether or not the achievement is done.

        /// </summary>
        [JsonProperty("done")]
        public bool Done { get; set; }

        /// <summary>
        /// This attribute contains an array of numbers, giving more specific information on the progress for the achievement. 
        /// The meaning of each value varies with each achievement. (More detail into what these bits mean will be added in a future update to v2/achievements.)
        /// </summary>
        [JsonProperty("bits")]
        public List<object> Bits { get; set; }

        /// <summary>
        /// The number of times the achievement has been completed if the achievement is repeatable.
        /// </summary>
        [JsonProperty("repeated")]
        public int? Repeated { get; set; }

        /// <summary>
        /// Whether or not the achievement is unlocked
        /// </summary>
        [JsonProperty("unlocked")]
        public bool? Unlocked { get; set; }
    }
}
