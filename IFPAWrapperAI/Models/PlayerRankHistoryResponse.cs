using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class PlayerRankHistoryResponse
    {
        [JsonPropertyName("player_id")]
        public int PlayerId { get; set; }
        [JsonPropertyName("system")]
        public string System { get; set; }
        [JsonPropertyName("active_flag")]
        public bool ActiveFlag { get; set; }
        [JsonPropertyName("rank_history")]
        public List<PlayerRankHistory> RankHistory { get; set; }
        [JsonPropertyName("rating_history")]
        public List<PlayerRatingHistory> RatingHistory { get; set; }
    }
}
