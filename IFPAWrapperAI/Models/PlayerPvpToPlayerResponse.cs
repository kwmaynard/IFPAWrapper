using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerPvpToPlayerResponse
    {
        [JsonProperty("player_1")]
        public PlayerPvpPlayer Player1 { get; set; }

        [JsonProperty("player_2")]
        public PlayerPvpPlayer Player2 { get; set; }

        [JsonProperty("pvp")]
        public List<PlayerPvpTournament> Pvp { get; set; }
    }
}