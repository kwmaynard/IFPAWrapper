using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class SeriesResult
    {
        [JsonPropertyName("player_id")]
        public int PlayerId { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("total_points")]
        public double TotalPoints { get; set; }
        [JsonPropertyName("series_rank")]
        public int SeriesRank { get; set; }
        [JsonPropertyName("region_code")]
        public string RegionCode { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        [JsonPropertyName("stateprov")]
        public string StateProv { get; set; }
        [JsonPropertyName("profile_photo_url")]
        public string ProfilePhotoUrl { get; set; }
    }
}
