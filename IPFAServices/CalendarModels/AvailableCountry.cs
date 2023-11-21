namespace IPFAServices.CalendarModels
{
    using Newtonsoft.Json;

    public class AvailableCountry
    {
        [JsonProperty("country_name")]
        public string CountryName { get; set; }
    }
}