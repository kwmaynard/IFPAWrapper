namespace IPFAServices.PlayerModels
{
    using Newtonsoft.Json;

    public class Player : PlayerLocation
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("age")]
        public int? Age { get; set; }

        [JsonProperty("excluded_flag")]
        public string ExcludedFlag { get; set; }

        [JsonProperty("ifpa_registered")]
        public string IfpaRegistered { get; set; }
    }
}