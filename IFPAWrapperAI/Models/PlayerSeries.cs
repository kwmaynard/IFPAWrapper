using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerSeries
    {
        [JsonProperty("series_code")]
        public string SeriesCode { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("total_points")]
        public double TotalPoints { get; set; }

        [JsonProperty("series_rank")]
        public int SeriesRank { get; set; }
    }
}