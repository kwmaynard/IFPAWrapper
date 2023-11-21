namespace IPFAServices.PlayerModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PlayerHistoryRoot
    {
        [JsonProperty("player")]
        public PlayerBase Player { get; set; }

        [JsonProperty("rank_history")]
        public List<RankHistory> RankHistory { get; set; }

        [JsonProperty("rating_history")]
        public List<RatingHistory> RatingHistory { get; set; }
    }
}