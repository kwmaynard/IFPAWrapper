namespace IPFAServices.PlayerModels
{
    using Newtonsoft.Json;

    public class PlayerBase
    {
        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}