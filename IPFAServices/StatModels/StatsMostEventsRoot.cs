namespace IPFAServices.StatModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StatsMostEventsRoot
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stats")]
        public List<StatsMostEvents> Stats { get; set; }
    }
}