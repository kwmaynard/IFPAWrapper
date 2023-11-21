namespace IPFAServices.PlayerModels
{
    using Newtonsoft.Json;

    public class PlayerRoot
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("player_stats")]
        public PlayerStats PlayerStats { get; set; }
    }
}