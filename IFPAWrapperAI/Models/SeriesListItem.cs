using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class SeriesListItem
    {
        [JsonProperty("series_code")]
        public string SeriesCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }
}