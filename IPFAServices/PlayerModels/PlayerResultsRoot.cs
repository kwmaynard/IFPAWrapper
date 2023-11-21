namespace IPFAServices.PlayerModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PlayerResultsRoot
    {
        [JsonProperty("player_id")]
        public int? PlayerId { get; set; }

        [JsonProperty("results_count")]
        public int? ResultsCount { get; set; }

        [JsonProperty("results")]
        public List<EventResult> Results { get; set; }
    }
}