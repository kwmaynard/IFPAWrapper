using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class PlayerStats
    {
    [JsonPropertyName("system")]
    public PlayerStatsSystem System { get; set; }
    }
}
