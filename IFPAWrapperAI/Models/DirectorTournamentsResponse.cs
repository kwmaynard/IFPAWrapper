using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    public class DirectorTournamentsResponse
    {
        [JsonProperty("director_id")]
        public int DirectorId { get; set; }

        [JsonProperty("tournaments")]
        public List<Tournament> Tournaments { get; set; }
    }
}