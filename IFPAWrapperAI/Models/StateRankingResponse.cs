using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class StateRankingResponse
    {
        [JsonPropertyName("stateprov")]
        public string StateProv { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("results")]
        public List<RankingResult> Results { get; set; }
    }
}
