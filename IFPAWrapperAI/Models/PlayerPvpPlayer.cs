using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerPvpPlayer
    {
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("excluded_flag")]
        public bool ExcludedFlag { get; set; }

        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}