using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class TournamentResultsResponse
    {
        [JsonPropertyName("tournament_id")]
        public int TournamentId { get; set; }
        [JsonPropertyName("results")]
        public List<TournamentResult> Results { get; set; }
    }
}
