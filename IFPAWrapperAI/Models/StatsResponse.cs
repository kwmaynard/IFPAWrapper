using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class StatsResponse
    {
    [JsonPropertyName("system")]
    public string System { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("results")]
    public List<StatsResult> Results { get; set; }
    }
}
