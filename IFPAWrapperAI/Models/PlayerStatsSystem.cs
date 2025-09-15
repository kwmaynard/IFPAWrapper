using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class PlayerStatsSystem
    {
        [JsonPropertyName("MAIN")]
        public PlayerStatsDetail Main { get; set; }
        [JsonPropertyName("WOMEN")]
        public PlayerStatsDetail Women { get; set; }
    }
}
