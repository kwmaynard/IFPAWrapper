namespace IPFAServices.PlayerModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PlayerPvpRoot
    {
        [JsonProperty("player_id")]
        public int? PlayerId { get; set; }

        [JsonProperty("total_competitors")]
        public int? TotalCompetitors { get; set; }

        [JsonProperty("pvp")]
        public List<PlayerPvp> Pvp { get; set; }
    }
}