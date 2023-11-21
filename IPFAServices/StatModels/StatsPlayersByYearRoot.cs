namespace IPFAServices.StatModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StatsPlayersByYearRoot
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stats")]
        public List<StatsPlayersByYear> Stats { get; set; }
    }
}