namespace IPFAServices.StatModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StatsEventsPerYearRoot
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stats")]
        public List<StatsEventsPerYear> Stats { get; set; }
    }
}