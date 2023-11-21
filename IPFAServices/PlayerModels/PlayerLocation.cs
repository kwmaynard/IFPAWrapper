namespace IPFAServices.PlayerModels
{
    using Newtonsoft.Json;

    public class PlayerLocation : PlayerBase
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }
    }
}