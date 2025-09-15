using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class TournamentSearchResponse
    {
        [JsonPropertyName("search_filter")]
        public TournamentSearchFilter SearchFilter { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
        [JsonPropertyName("results")]
        public List<TournamentSearchResult> Results { get; set; }
    }
}
