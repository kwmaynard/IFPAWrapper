using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class CountryRankingResponse
    {
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}