namespace IPFAServices.TournamentModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TournamentSearchRoot
    {
        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("tournament")]
        public List<Tournament> Tournament { get; set; }
    }
}