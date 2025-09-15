using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class Director
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("profile_photo")]
        public string CountryName { get; set; }
        
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        
        [JsonPropertyName("city")]
        public string City { get; set; }
        
        [JsonPropertyName("stateprov")]
        public string StateProv { get; set; }
        
        [JsonPropertyName("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}
