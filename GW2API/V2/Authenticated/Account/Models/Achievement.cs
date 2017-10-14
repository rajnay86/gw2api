using System.Collections.Generic;

namespace GW2API.V2.Authenticated.Account.Models
{
    public class Achievement
    {
        public int id { get; set; }
        public int current { get; set; }
        public int max { get; set; }
        public bool done { get; set; }
        public List<object> bits { get; set; }
        public int? repeated { get; set; }
        public bool? unlocked { get; set; }
    }
}
