using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class Director
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_photo")]
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