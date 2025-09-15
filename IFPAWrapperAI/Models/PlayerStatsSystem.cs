using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerStatsSystem
    {
        [JsonProperty("MAIN")]
        public PlayerStatsDetail Main { get; set; }

        [JsonProperty("WOMEN")]
        public PlayerStatsDetail Women { get; set; }
    }
}