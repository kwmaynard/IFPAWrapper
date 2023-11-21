namespace IPFAServices.TournamentModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TournamentResult
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("wppr_rank")]
        public string WpprRank { get; set; }

        [JsonProperty("ratings_value")]
        public string RatingsValue { get; set; }

        [JsonProperty("points")]
        public string Points { get; set; }
    }
}