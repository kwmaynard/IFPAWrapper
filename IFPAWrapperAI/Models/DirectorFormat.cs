using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class DirectorFormat
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
