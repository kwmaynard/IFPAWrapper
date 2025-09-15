using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class PlayerMultiResponse
    {
        [JsonPropertyName("player")]
        public List<Player> Players { get; set; }
        // ...existing code...
    }
}
