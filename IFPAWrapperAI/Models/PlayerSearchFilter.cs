using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class PlayerSearchFilter
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("stateprov")]
        public string StateProv { get; set; }
        [JsonPropertyName("tournament")]
        public string Tournament { get; set; }
        [JsonPropertyName("tournament_position")]
        public int TournamentPosition { get; set; }
        [JsonPropertyName("include_unranked")]
        public string IncludeUnranked { get; set; }
    }
}
