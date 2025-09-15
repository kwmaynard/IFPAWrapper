using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class TournamentSearchFilter
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("stateprov")]
        public string StateProv { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("director_id")]
        public int? DirectorId { get; set; }
        [JsonPropertyName("year")]
        public int? Year { get; set; }
    }
}
