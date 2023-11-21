namespace IPFAServices.StatModels
{
    using Newtonsoft.Json;

    public class StatsEventsPerYear
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("country_count")]
        public string CountryCount { get; set; }

        [JsonProperty("periodic_count")]
        public string PeriodicCount { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("stats_rank")]
        public int? StatsRank { get; set; }
    }
}