using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class DirectorSearchResponse
    {
        [JsonProperty("search_filter")]
        public DirectorSearchFilter SearchFilter { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public List<DirectorSearchResult> Results { get; set; }
    }
}