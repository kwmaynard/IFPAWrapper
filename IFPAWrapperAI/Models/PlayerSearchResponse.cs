using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class PlayerSearchResponse
    {
        [JsonPropertyName("search_filter")]
        public PlayerSearchFilter SearchFilter { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
        [JsonPropertyName("results")]
        public List<PlayerSearchResult> Results { get; set; }
    }
}
