using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerResultsResponse
    {
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("results_type")]
        public string ResultsType { get; set; }

        [JsonProperty("results_count")]
        public int ResultsCount { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("results")]
        public List<PlayerResult> Results { get; set; }
    }
}