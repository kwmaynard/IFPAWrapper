namespace IPFAServices.TournamentModels
{
    using Newtonsoft.Json;

    public class Event
    {
        [JsonProperty("event_date")]
        public string EventDate { get; set; }

        [JsonProperty("winner_player_id")]
        public string WinnerPlayerId { get; set; }

        [JsonProperty("winner_first_name")]
        public string WinnerFirstName { get; set; }

        [JsonProperty("winner_last_name")]
        public string WinnerLastName { get; set; }
    }
}