namespace IPFAServices
{
    using IPFAServices.CalendarModels;

    /// <summary>
    /// Retrieves player data from the IPFA API.
    /// </summary>
    /// <see cref="https://www.ifpapinball.com/api/documentation/calendar/"/>
    public class CalendarService : ServiceBase, ICalendarService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarService"/> class.
        /// </summary>
        /// <param name="apiKey">Key needed to access API</param>
        /// <param name="baseUri">The root of the API's url.</param>
        public CalendarService(string apiKey, string baseUri)
            : base(apiKey, baseUri)
        {
        }

        /// <summary>
        /// Get a list of current calendar entries.
        /// </summary>
        /// <param name="country">Filter on a specific country.</param>
        /// <returns>A calender list object.</returns>
        public CalendarListRoot GetActiveCalendarEntries(string country)
        {
            var requestUri = this.BuildUri("calendar/active", $"&country={country}");
            return this.GenericGet<CalendarListRoot>(requestUri);
        }

        /// <summary>
        /// Get a list of past calendar entries.
        /// </summary>
        /// <param name="id">Filter on a specific country.</param>
        /// <returns>A calender list object.</returns>
        public CalendarListRoot GetPastCalendarEntries(string country)
        {
            var requestUri = this.BuildUri("calendar/history", $"&country={country}");
            return this.GenericGet<CalendarListRoot>(requestUri);
        }

        /// <summary>
        /// Get a list of past calendar entries.
        /// </summary>
        /// <param name="country">Calendar entry ID.</param>
        /// <returns>A calender list object.</returns>
        public CalendarEntryRoot GetCalendarEntry(int id)
        {
            var requestUri = this.BuildUri($"calendar/{id}", string.Empty);
            return this.GenericGet<CalendarEntryRoot>(requestUri);
        }

        /// <summary>
        /// Get data regarding a specific calendar entry..
        /// </summary>
        /// <param name="id">Filter on a specific country.</param>
        /// <returns>A calender list object.</returns>
        public CalendarSearchRoot GetCalendarSearch(string address, int miles)
        {
            var requestUri = this.BuildUri("calendar/search", $"&address={address}&m={miles}");
            return this.GenericGet<CalendarSearchRoot>(requestUri);
        }
    }
}