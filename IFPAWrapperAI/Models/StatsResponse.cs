using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class StatsResponse
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public List<StatsResult> Results { get; set; }
    }
}