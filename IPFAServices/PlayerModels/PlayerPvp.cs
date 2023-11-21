namespace IPFAServices.PlayerModels
{
    using Newtonsoft.Json;

    public class PlayerPvp : PlayerBase
    {
        [JsonProperty("win_count")]
        public string WinCount { get; set; }

        [JsonProperty("loss_count")]
        public string LossCount { get; set; }

        [JsonProperty("tie_count")]
        public string TieCount { get; set; }
    }
}