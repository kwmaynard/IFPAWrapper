namespace IPFAServices.TournamentModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TournamentListRoot
    {
        [JsonProperty("tournament")]
        public List<Tournament> Tournament { get; set; }

        [JsonProperty("total_results")]
        public string TotalResults { get; set; }
    }
}