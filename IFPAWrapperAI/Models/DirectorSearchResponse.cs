using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class DirectorSearchResponse
    {
            [JsonPropertyName("search_filter")]
            public DirectorSearchFilter SearchFilter { get; set; }

            [JsonPropertyName("count")]
            public int Count { get; set; }

            [JsonPropertyName("total_results")]
            public int TotalResults { get; set; }

            [JsonPropertyName("results")]
            public List<DirectorSearchResult> Results { get; set; }
    }
}
