using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class FinishPosition
    {
        [JsonProperty("player_1")]
        public int Player1 { get; set; }

        [JsonProperty("player_2")]
        public int Player2 { get; set; }
    }
}