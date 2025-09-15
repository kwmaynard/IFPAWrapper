using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class Player
    {
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("excluded_flag")]
        public bool ExcludedFlag { get; set; }

        [JsonProperty("age")]
        public int? Age { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("ifpa_registered")]
        public bool IfpaRegistered { get; set; }

        [JsonProperty("womens_flag")]
        public bool WomensFlag { get; set; }

        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }

        [JsonProperty("matchplay_events")]
        public MatchplayEvents MatchplayEvents { get; set; }

        [JsonProperty("twitch_username")]
        public string TwitchUsername { get; set; }

        [JsonProperty("pinside_username")]
        public string PinsideUsername { get; set; }

        [JsonProperty("player_stats")]
        public PlayerStatsDetail PlayerStats { get; set; }

        [JsonProperty("series")]
        public PlayerSeries Series { get; set; }
    }
}