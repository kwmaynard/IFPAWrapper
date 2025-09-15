using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerPvpRecord
    {
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("win_count")]
        public int WinCount { get; set; }

        [JsonProperty("loss_count")]
        public int LossCount { get; set; }

        [JsonProperty("tie_count")]
        public int TieCount { get; set; }

        [JsonProperty("current_rank")]
        public int CurrentRank { get; set; }
    }
}