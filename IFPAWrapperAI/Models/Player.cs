using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class Player 
    {
    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("initials")]
    public string Initials { get; set; }

    [JsonPropertyName("excluded_flag")]
    public bool ExcludedFlag { get; set; }

    [JsonPropertyName("age")]
    public int? Age { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("stateprov")]
    public string StateProv { get; set; }

    [JsonPropertyName("country_name")]
    public string CountryName { get; set; }

    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    [JsonPropertyName("ifpa_registered")]
    public bool IfpaRegistered { get; set; }

    [JsonPropertyName("womens_flag")]
    public bool WomensFlag { get; set; }

    [JsonPropertyName("profile_photo")]
    public string ProfilePhoto { get; set; }

    [JsonPropertyName("matchplay_events")]
    public MatchplayEvents MatchplayEvents { get; set; }

    [JsonPropertyName("twitch_username")]
    public string TwitchUsername { get; set; }

    [JsonPropertyName("pinside_username")]
    public string PinsideUsername { get; set; }

    [JsonPropertyName("player_stats")]
    public PlayerStatsDetail PlayerStats { get; set; }
        [JsonPropertyName("series")]
        public PlayerSeries Series { get; set; }
    }
}
