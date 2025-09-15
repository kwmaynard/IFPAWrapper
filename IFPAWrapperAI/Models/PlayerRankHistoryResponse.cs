using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerRankHistoryResponse
    {
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("active_flag")]
        public bool ActiveFlag { get; set; }

        [JsonProperty("rank_history")]
        public List<PlayerRankHistory> RankHistory { get; set; }

        [JsonProperty("rating_history")]
        public List<PlayerRatingHistory> RatingHistory { get; set; }
    }
}