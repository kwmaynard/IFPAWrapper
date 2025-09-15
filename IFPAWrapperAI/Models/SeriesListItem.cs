using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class SeriesListItem
    {
        [JsonPropertyName("series_code")]
        public string SeriesCode { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("region_code")]
        public string RegionCode { get; set; }
        [JsonPropertyName("year")]
        public int Year { get; set; }
    }
}
