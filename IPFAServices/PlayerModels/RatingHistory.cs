namespace IPFAServices.PlayerModels
{
    using Newtonsoft.Json;

    public class RatingHistory
    {
        [JsonProperty("rating_date")]
        public string RatingDate { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }
    }
}