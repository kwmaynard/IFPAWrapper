using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class MatchplayEvents
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}