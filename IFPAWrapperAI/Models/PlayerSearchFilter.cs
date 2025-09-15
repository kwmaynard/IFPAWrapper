using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerSearchFilter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        [JsonProperty("tournament")]
        public string Tournament { get; set; }

        [JsonProperty("tournament_position")]
        public int TournamentPosition { get; set; }

        [JsonProperty("include_unranked")]
        public string IncludeUnranked { get; set; }
    }
}