using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class StateRankingResponse
    {
        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}