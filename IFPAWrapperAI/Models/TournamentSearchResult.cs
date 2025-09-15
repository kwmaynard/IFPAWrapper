using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class TournamentSearchResult
    {
        [JsonPropertyName("tournament_id")]
        public int TournamentId { get; set; }
        [JsonPropertyName("tournament_name")]
        public string TournamentName { get; set; }
        [JsonPropertyName("event_name")]
        public string EventName { get; set; }
        [JsonPropertyName("event_start_date")]
        public string EventStartDate { get; set; }
        [JsonPropertyName("event_end_date")]
        public string EventEndDate { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("stateprov")]
        public string StateProv { get; set; }
        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        [JsonPropertyName("director_id")]
        public int DirectorId { get; set; }
        [JsonPropertyName("director_name")]
        public string DirectorName { get; set; }
        [JsonPropertyName("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}
