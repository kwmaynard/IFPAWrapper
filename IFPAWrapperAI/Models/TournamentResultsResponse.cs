using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class TournamentResultsResponse
    {
        [JsonProperty("tournament_id")]
        public int TournamentId { get; set; }

        [JsonProperty("results")]
        public List<TournamentResult> Results { get; set; }
    }
}