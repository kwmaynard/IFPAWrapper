namespace IPFAServices.CalendarModels
{
    using Newtonsoft.Json;

    public class AvailableMonth
    {
        [JsonProperty("date_month")]
        public string DateMonth { get; set; }
    }
}