using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerPvpResponse
    {
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("total_competitors")]
        public int TotalCompetitors { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("pvp")]
        public List<PlayerPvpRecord> Pvp { get; set; }
    }
}