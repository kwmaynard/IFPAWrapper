using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerStats
    {
        [JsonProperty("system")]
        public PlayerStatsSystem System { get; set; }
    }
}