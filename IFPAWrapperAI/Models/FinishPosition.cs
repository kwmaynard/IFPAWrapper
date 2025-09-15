using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class FinishPosition
    {
        [JsonPropertyName("player_1")]
        public int Player1 { get; set; }
        [JsonPropertyName("player_2")]
        public int Player2 { get; set; }
    }
}
