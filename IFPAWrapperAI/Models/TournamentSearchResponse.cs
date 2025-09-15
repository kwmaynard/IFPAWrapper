using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class TournamentSearchResponse
    {
        [JsonProperty("search_filter")]
        public TournamentSearchFilter SearchFilter { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public List<TournamentSearchResult> Results { get; set; }
    }
}