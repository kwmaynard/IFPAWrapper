using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class TournamentSearchResult
    {
        [JsonProperty("tournament_id")]
        public int TournamentId { get; set; }

        [JsonProperty("tournament_name")]
        public string TournamentName { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event_start_date")]
        public string EventStartDate { get; set; }

        [JsonProperty("event_end_date")]
        public string EventEndDate { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("director_id")]
        public int DirectorId { get; set; }

        [JsonProperty("director_name")]
        public string DirectorName { get; set; }

        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}