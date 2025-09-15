using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class StatsResult
    {
        [JsonPropertyName("player_id")]
        public int PlayerId { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        [JsonPropertyName("stateprov")]
        public string StateProv { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("profile_photo_url")]
        public string ProfilePhotoUrl { get; set; }
        [JsonPropertyName("stats")]
        public PlayerStatsDetail Stats { get; set; }
    }
}
