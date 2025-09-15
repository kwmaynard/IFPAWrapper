using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class RegionRankingResponse
    {
        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}