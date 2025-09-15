using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerSearchResponse
    {
        [JsonProperty("search_filter")]
        public PlayerSearchFilter SearchFilter { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public List<PlayerSearchResult> Results { get; set; }
    }
}