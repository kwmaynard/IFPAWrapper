using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class RankingResponse
    {
        [JsonPropertyName("system")]
        public string System { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
        [JsonPropertyName("results")]
        public List<RankingResult> Results { get; set; }
    }
}
