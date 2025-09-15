using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class PlayerPvpToPlayerResponse
    {
        [JsonPropertyName("player_1")]
        public PlayerPvpPlayer Player1 { get; set; }
        [JsonPropertyName("player_2")]
        public PlayerPvpPlayer Player2 { get; set; }
        [JsonPropertyName("pvp")]
        public List<PlayerPvpTournament> Pvp { get; set; }
    }
}
