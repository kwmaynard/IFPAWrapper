using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class DirectorStats
    {
        [JsonProperty("tournament_count")]
        public int TournamentCount { get; set; }

        [JsonProperty("unique_location_count")]
        public int UniqueLocationCount { get; set; }

        [JsonProperty("women_tournament_count")]
        public int WomenTournamentCount { get; set; }

        [JsonProperty("league_count")]
        public int LeagueCount { get; set; }

        [JsonProperty("highest_value")]
        public int HighestValue { get; set; }

        [JsonProperty("average_value")]
        public int AverageValue { get; set; }

        [JsonProperty("total_player_count")]
        public int TotalPlayerCount { get; set; }

        [JsonProperty("unique_player_count")]
        public int UniquePlayerCount { get; set; }

        [JsonProperty("first_time_player_count")]
        public int FirstTimePlayerCount { get; set; }

        [JsonProperty("repeat_player_count")]
        public int RepeatPlayerCount { get; set; }

        [JsonProperty("largest_event_count")]
        public int LargestEventCount { get; set; }

        [JsonProperty("single_format_count")]
        public int SingleFormatCount { get; set; }

        [JsonProperty("multiple_format_count")]
        public int MultipleFormatCount { get; set; }

        [JsonProperty("unknown_format_count")]
        public int UnknownFormatCount { get; set; }

        [JsonProperty("formats")]
        public DirectorFormat Formats { get; set; }
    }
}