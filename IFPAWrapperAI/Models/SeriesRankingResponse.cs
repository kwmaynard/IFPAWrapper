using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class SeriesRankingResponse
    {
        [JsonPropertyName("series_code")]
        public string SeriesCode { get; set; }
        [JsonPropertyName("year")]
        public int Year { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("results")]
        public List<RankingResult> Results { get; set; }
    }
}
