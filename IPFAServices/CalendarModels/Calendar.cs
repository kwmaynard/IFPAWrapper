﻿namespace IPFAServices.CalendarModels
{
    using Newtonsoft.Json;

    public class Calendar
    {
        [JsonProperty("calendar_id")]
        public string CalendarId { get; set; }

        [JsonProperty("tournament_id")]
        public string TournamentId { get; set; }

        [JsonProperty("tournament_name")]
        public string TournamentName { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("director_name")]
        public string DirectorName { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("private_flag")]
        public string PrivateFlag { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }
}