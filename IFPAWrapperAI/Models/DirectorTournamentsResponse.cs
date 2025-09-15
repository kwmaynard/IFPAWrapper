using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace IFPAWrapper.Models
{
    public class DirectorTournamentsResponse
    {
        [JsonPropertyName("director_id")]
        public int DirectorId { get; set; }
        [JsonPropertyName("tournaments")]
        public List<Tournament> Tournaments { get; set; }
    }
}
