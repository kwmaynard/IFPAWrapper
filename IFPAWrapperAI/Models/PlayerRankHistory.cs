using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerRankHistory
    {
        [JsonProperty("rank_date")]
        public string RankDate { get; set; }

        [JsonProperty("rank_postiion")]
        public int RankPosition { get; set; }

        [JsonProperty("wppr_points")]
        public double WpprPoints { get; set; }

        [JsonProperty("tournaments_played_count")]
        public int TournamentsPlayedCount { get; set; }
    }
}