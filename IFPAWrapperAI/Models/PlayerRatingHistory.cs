using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class PlayerRatingHistory
    {
        [JsonPropertyName("rating_date")]
        public string RatingDate { get; set; }
        [JsonPropertyName("rating")]
        public double Rating { get; set; }
    }
}
