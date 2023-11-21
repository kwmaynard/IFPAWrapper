namespace IPFAServices.PlayerModels
{
    using Newtonsoft.Json;

    public class PlayerSearchResult : PlayerLocation
    {
        [JsonProperty("wppr_rank")]
        public string WpprRank { get; set; }
    }
}