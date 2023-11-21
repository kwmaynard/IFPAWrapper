namespace IPFAServices
{
    using IPFAServices.CalendarModels;

    /// <summary>
    /// Get data from the calendar from the IPFA API.
    /// </summary>
    /// <see cref="https://www.ifpapinball.com/api/documentation/calendar/"/>
    public interface ICalendarService
    {
        /// <summary>
        /// Get a list of current calendar entries.
        /// </summary>
        /// <param name="country">Filter on a specific country.</param>
        /// <returns>A calender list object.</returns>
        CalendarListRoot GetActiveCalendarEntries(string country);

        /// <summary>
        /// Get a list of past calendar entries.
        /// </summary>
        /// <param name="id">Filter on a specific country.</param>
        /// <returns>A calender list object.</returns>
        CalendarListRoot GetPastCalendarEntries(string country);

        /// <summary>
        /// Get a list of past calendar entries.
        /// </summary>
        /// <param name="country">Calendar entry ID.</param>
        /// <returns>A calender list object.</returns>
        CalendarEntryRoot GetCalendarEntry(int id);

        /// <summary>
        /// Get data regarding a specific calendar entry..
        /// </summary>
        /// <param name="id">Filter on a specific country.</param>
        /// <returns>A calender list object.</returns>
        CalendarSearchRoot GetCalendarSearch(string address, int miles);
    }
}