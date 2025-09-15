using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class RankingResponse
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}