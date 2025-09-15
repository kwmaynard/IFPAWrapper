using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class PlayerSeries
    {
        [JsonPropertyName("series_code")]
        public string SeriesCode { get; set; }
        [JsonPropertyName("region_code")]
        public string RegionCode { get; set; }
        [JsonPropertyName("year")]
        public int Year { get; set; }
        [JsonPropertyName("total_points")]
        public double TotalPoints { get; set; }
        [JsonPropertyName("series_rank")]
        public int SeriesRank { get; set; }
    }
}
