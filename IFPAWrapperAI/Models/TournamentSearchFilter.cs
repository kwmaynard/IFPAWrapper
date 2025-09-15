using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class TournamentSearchFilter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("director_id")]
        public int? DirectorId { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }
    }
}