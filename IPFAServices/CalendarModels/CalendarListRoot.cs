namespace IPFAServices.CalendarModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CalendarListRoot
    {
        [JsonProperty("calendar")]
        public List<Calendar> Calendar { get; set; }

        [JsonProperty("total_entries")]
        public int TotalEntries { get; set; }

        [JsonProperty("available_months")]
        public List<AvailableMonth> AvailableMonths { get; set; }

        [JsonProperty("available_countries")]
        public List<AvailableCountry> AvailableCountries { get; set; }
    }
}