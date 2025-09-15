using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class SeriesRankingResponse
    {
        [JsonProperty("series_code")]
        public string SeriesCode { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}