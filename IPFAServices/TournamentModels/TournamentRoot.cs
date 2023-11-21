namespace IPFAServices.TournamentModels
{
    using Newtonsoft.Json;

    public class TournamentRoot
    {
        [JsonProperty("tournament")]
        public Tournament Tournament { get; set; }
    }
}