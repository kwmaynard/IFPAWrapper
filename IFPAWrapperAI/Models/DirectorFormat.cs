using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class DirectorFormat
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}