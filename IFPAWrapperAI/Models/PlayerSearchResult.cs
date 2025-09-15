using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerSearchResult
    {
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        [JsonProperty("wppr_rank")]
        public int WpprRank { get; set; }

        [JsonProperty("rating_value")]
        public double RatingValue { get; set; }

        [JsonProperty("profile_photo_url")]
        public string ProfilePhotoUrl { get; set; }
    }
}