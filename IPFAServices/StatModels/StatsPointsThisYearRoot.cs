namespace IPFAServices.StatModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StatsPointsThisYearRoot
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stats")]
        public List<StatsPointsThisYear> Stats { get; set; }
    }
}