using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class PlayerStatsDetail
    {
    [JsonPropertyName("current_rank")]
    public int CurrentRank { get; set; }
    [JsonPropertyName("last_month_rank")]
    public int LastMonthRank { get; set; }
    [JsonPropertyName("last_year_rank")]
    public int LastYearRank { get; set; }
    [JsonPropertyName("highest_rank")]
    public int HighestRank { get; set; }
    [JsonPropertyName("current_points")]
    public double CurrentPoints { get; set; }
    [JsonPropertyName("all_time_points")]
    public double AllTimePoints { get; set; }
    [JsonPropertyName("active_points")]
    public double ActivePoints { get; set; }
    [JsonPropertyName("inactive_points")]
    public double InactivePoints { get; set; }
    [JsonPropertyName("best_finish")]
    public int BestFinish { get; set; }
    [JsonPropertyName("best_finish_count")]
    public int BestFinishCount { get; set; }
    [JsonPropertyName("average_finish")]
    public double AverageFinish { get; set; }
    [JsonPropertyName("average_finish_last_year")]
    public double AverageFinishLastYear { get; set; }
    [JsonPropertyName("total_events_all_time")]
    public int TotalEventsAllTime { get; set; }
    [JsonPropertyName("total_active_events")]
    public int TotalActiveEvents { get; set; }
    [JsonPropertyName("total_events_away")]
    public int TotalEventsAway { get; set; }
    [JsonPropertyName("total_wins_last_3_years")]
    public int TotalWinsLast3Years { get; set; }
    [JsonPropertyName("top_3_last_3_years")]
    public int Top3Last3Years { get; set; }
    [JsonPropertyName("top_10_last_3_years")]
    public int Top10Last3Years { get; set; }
    [JsonPropertyName("ratings_rank")]
    public int RatingsRank { get; set; }
    [JsonPropertyName("ratings_value")]
    public double RatingsValue { get; set; }
    [JsonPropertyName("efficiency_rank")]
    public int EfficiencyRank { get; set; }
    [JsonPropertyName("efficiency_value")]
    public double EfficiencyValue { get; set; }

    }
}
