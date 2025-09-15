using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class RegionRankingResponse
    {
        [JsonPropertyName("region_code")]
        public string RegionCode { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("results")]
        public List<RankingResult> Results { get; set; }
    }
}
