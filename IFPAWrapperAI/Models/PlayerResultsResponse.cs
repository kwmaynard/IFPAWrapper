using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class PlayerResultsResponse
    {
        [JsonPropertyName("player_id")]
        public int PlayerId { get; set; }
        [JsonPropertyName("results_type")]
        public string ResultsType { get; set; }
        [JsonPropertyName("results_count")]
        public int ResultsCount { get; set; }
        [JsonPropertyName("system")]
        public string System { get; set; }
        [JsonPropertyName("results")]
        public List<PlayerResult> Results { get; set; }
    }
}
