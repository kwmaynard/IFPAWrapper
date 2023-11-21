namespace IPFAServices.CalendarModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CalendarSearchRoot
    {
        [JsonProperty("calendar")]
        public List<Calendar> Calendar { get; set; }

        [JsonProperty("total_entries")]
        public int TotalEntries { get; set; }
    }
}