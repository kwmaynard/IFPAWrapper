namespace IPFAServices.StatModels
{
    using Newtonsoft.Json;

    public class StatsPlayersByCountry
    {
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("stats_rank")]
        public int? StatsRank { get; set; }
    }
}