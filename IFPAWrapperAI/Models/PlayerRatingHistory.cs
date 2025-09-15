using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerRatingHistory
    {
        [JsonProperty("rating_date")]
        public string RatingDate { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }
    }
}