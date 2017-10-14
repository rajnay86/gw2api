using Newtonsoft.Json;

namespace GW2API.V2.Authenticated.Account.Models
{
    [JsonObject]
    public class Wallet
    {
        /// <summary>
        /// The currency's ID.
        /// </summary>
        [JsonProperty("id")]
        public int CurrencyId { get; set; }

        /// <summary>
        /// The amount of this currency.
        /// </summary>
        [JsonProperty("value")]
        public int Amount { get; set; }

        /// <summary>
        /// Display string for the amount of this currency
        /// </summary>
        public string AmountDisplay
        {
            get
            {
                string amount = Amount.ToString();
                if(CurrencyId == 1)
                {
                    amount = FormatCoin(amount);

                }
                return amount;
            }
        }

        private static string FormatCoin(string amount)
        {
            var copperIndex = amount.Length - 2;
            var silverIndex = amount.Length - 4;
            var copper = amount.Substring(copperIndex);
            var silver = amount.Substring(silverIndex, 2);
            var gold = amount.Substring(0, silverIndex);
            amount = $"{gold}g {silver}s {copper}c";
            return amount;
        }
    }
}