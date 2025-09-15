using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class PlayerRankHistory
    {
        [JsonPropertyName("rank_date")]
        public string RankDate { get; set; }
        [JsonPropertyName("rank_postiion")]
        public int RankPosition { get; set; }
        [JsonPropertyName("wppr_points")]
        public double WpprPoints { get; set; }
        [JsonPropertyName("tournaments_played_count")]
        public int TournamentsPlayedCount { get; set; }
    }
}
