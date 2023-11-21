namespace IPFAServices.PlayerModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RankingsRoot
    {
        [JsonProperty("total_count")]
        public string TotalCount { get; set; }

        [JsonProperty("sub_category")]
        public string SubCategory { get; set; }

        [JsonProperty("rankings")]
        public List<Ranking> Rankings { get; set; }
    }
}