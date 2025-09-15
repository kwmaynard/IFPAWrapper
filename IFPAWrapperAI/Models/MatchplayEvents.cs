using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class MatchplayEvents
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }
    }
}
