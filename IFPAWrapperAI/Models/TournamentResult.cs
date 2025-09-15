using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class TournamentResult
    {
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("points")]
        public double Points { get; set; }

        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}