using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerPvpTournament
    {
        [JsonProperty("tournament_name")]
        public string TournamentName { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("tournament_id")]
        public int TournamentId { get; set; }

        [JsonProperty("event_end_date")]
        public string EventEndDate { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("finish_position")]
        public FinishPosition FinishPosition { get; set; }
    }
}