namespace IPFAServices.PlayerModels
{
    using Newtonsoft.Json;

    public class EventResult
    {
        [JsonProperty("tournament_id")]
        public string TournamentId { get; set; }

        [JsonProperty("tournament_name")]
        public string TournamentName { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event_date")]
        public string EventDate { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("periodic_flag")]
        public string PeriodicFlag { get; set; }

        [JsonProperty("wppr_state")]
        public string WpprState { get; set; }

        [JsonProperty("original_points")]
        public string OriginalPoints { get; set; }

        [JsonProperty("current_points")]
        public string CurrentPoints { get; set; }
    }
}