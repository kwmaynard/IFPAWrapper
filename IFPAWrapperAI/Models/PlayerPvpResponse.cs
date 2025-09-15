using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class PlayerPvpResponse
    {
        [JsonPropertyName("player_id")]
        public int PlayerId { get; set; }
        [JsonPropertyName("total_competitors")]
        public int TotalCompetitors { get; set; }
        [JsonPropertyName("system")]
        public string System { get; set; }
        [JsonPropertyName("pvp")]
        public List<PlayerPvpRecord> Pvp { get; set; }
    }
}
