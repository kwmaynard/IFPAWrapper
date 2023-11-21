namespace IPFAServices.PlayerModels
{
    using Newtonsoft.Json;

    public class RankHistory
    {
        [JsonProperty("rank_date")]
        public string RankDate { get; set; }

        [JsonProperty("rank_position")]
        public string RankPosition { get; set; }

        [JsonProperty("wppr_points")]
        public string WpprPoints { get; set; }
    }
}