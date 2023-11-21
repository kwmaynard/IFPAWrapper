namespace IPFAServices.CalendarModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CalendarEntryRoot
    {
        [JsonProperty("calendar")]
        public List<Calendar> Calendar { get; set; }
    }
}