namespace IPFAServices.StatModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StatsBiggestMoversRoot
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stats")]
        public List<StatsBiggestMovers> Stats { get; set; }
    }
}