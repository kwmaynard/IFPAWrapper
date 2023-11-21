namespace IPFAServices.TournamentModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Tournament
    {
        [JsonProperty("tournament_id")]
        public string TournamentId { get; set; }

        [JsonProperty("tournament_name")]
        public string TournamentName { get; set; }

        [JsonProperty("tournament_type")]
        public string TournamentType { get; set; }

        [JsonProperty("prestige_flag")]
        public string PrestigeFlag { get; set; }

        [JsonProperty("periodic_flag")]
        public string PeriodicFlag { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event_date")]
        public string EventDate { get; set; }

        [JsonProperty("periodic_count")]
        public int? PeriodicCount { get; set; }

        [JsonProperty("rating_strength")]
        public string RatingStrength { get; set; }

        [JsonProperty("ranking_strength")]
        public string RankingStrength { get; set; }

        [JsonProperty("base_value")]
        public string BaseValue { get; set; }

        [JsonProperty("event_value")]
        public string EventValue { get; set; }

        [JsonProperty("results")]
        public List<TournamentResult> Results { get; set; }

        [JsonProperty("winner_name")]
        public string WinnerName { get; set; }

        [JsonProperty("winner_player_id")]
        public string WinnerPlayerId { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("player_count")]
        public string PlayerCount { get; set; }

        [JsonProperty("event_count")]
        public string EventCount { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("last_event_date")]
        public string LastEventDate { get; set; }
    }
}