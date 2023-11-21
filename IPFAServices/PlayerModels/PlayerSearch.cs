namespace IPFAServices.PlayerModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PlayerSearchRoot
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("search")]
        public List<PlayerSearchResult> Search { get; set; }
    }
}