using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class PlayerPvpPlayer
    {
    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    [JsonPropertyName("excluded_flag")]
    public bool ExcludedFlag { get; set; }

    [JsonPropertyName("profile_photo")]
    public string ProfilePhoto { get; set; }
    }
}
