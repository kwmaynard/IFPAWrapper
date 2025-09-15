using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class DirectorSearchResult
    {
        [JsonProperty("director_id")]
        public int DirectorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}