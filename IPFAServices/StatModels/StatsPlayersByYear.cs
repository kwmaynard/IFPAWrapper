namespace IPFAServices.StatModels
{
    using Newtonsoft.Json;

    public class StatsPlayersByYear
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("previous_year_count")]
        public string PreviousYearCount { get; set; }

        [JsonProperty("previous_2_year_count")]
        public string Previous2YearCount { get; set; }

        [JsonProperty("stats_rank")]
        public int? StatsRank { get; set; }
    }
}