using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerStatsDetail
    {
        [JsonProperty("current_rank")]
        public int CurrentRank { get; set; }

        [JsonProperty("last_month_rank")]
        public int LastMonthRank { get; set; }

        [JsonProperty("last_year_rank")]
        public int LastYearRank { get; set; }

        [JsonProperty("highest_rank")]
        public int HighestRank { get; set; }

        [JsonProperty("current_points")]
        public double CurrentPoints { get; set; }

        [JsonProperty("all_time_points")]
        public double AllTimePoints { get; set; }

        [JsonProperty("active_points")]
        public double ActivePoints { get; set; }

        [JsonProperty("inactive_points")]
        public double InactivePoints { get; set; }

        [JsonProperty("best_finish")]
        public int BestFinish { get; set; }

        [JsonProperty("best_finish_count")]
        public int BestFinishCount { get; set; }

        [JsonProperty("average_finish")]
        public double AverageFinish { get; set; }

        [JsonProperty("average_finish_last_year")]
        public double AverageFinishLastYear { get; set; }

        [JsonProperty("total_events_all_time")]
        public int TotalEventsAllTime { get; set; }

        [JsonProperty("total_active_events")]
        public int TotalActiveEvents { get; set; }

        [JsonProperty("total_events_away")]
        public int TotalEventsAway { get; set; }

        [JsonProperty("total_wins_last_3_years")]
        public int TotalWinsLast3Years { get; set; }

        [JsonProperty("top_3_last_3_years")]
        public int Top3Last3Years { get; set; }

        [JsonProperty("top_10_last_3_years")]
        public int Top10Last3Years { get; set; }

        [JsonProperty("ratings_rank")]
        public int RatingsRank { get; set; }

        [JsonProperty("ratings_value")]
        public double RatingsValue { get; set; }

        [JsonProperty("efficiency_rank")]
        public int EfficiencyRank { get; set; }

        [JsonProperty("efficiency_value")]
        public double EfficiencyValue { get; set; }
    }
}