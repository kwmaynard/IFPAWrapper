using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class PlayerMultiResponse
    {
        [JsonProperty("player")]
        public List<Player> Players { get; set; }

        // ...existing code...
    }
}