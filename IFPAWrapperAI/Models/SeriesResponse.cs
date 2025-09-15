using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class SeriesResponse
    {
        [JsonProperty("series_code")]
        public string SeriesCode { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public List<SeriesResult> Results { get; set; }
    }
}