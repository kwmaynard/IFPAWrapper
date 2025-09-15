using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class PlayerPvpTournament
    {
        [JsonPropertyName("tournament_name")]
        public string TournamentName { get; set; }
        [JsonPropertyName("event_name")]
        public string EventName { get; set; }
        [JsonPropertyName("tournament_id")]
        public int TournamentId { get; set; }
        [JsonPropertyName("event_end_date")]
        public string EventEndDate { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        [JsonPropertyName("finish_position")]
        public FinishPosition FinishPosition { get; set; }
    }
}
