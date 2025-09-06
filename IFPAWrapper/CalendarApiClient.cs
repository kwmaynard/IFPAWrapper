// -----------------------------------------------------------------------
// <copyright file="CalendarService.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices
{
    using IFPAServices.CalendarModels;

    /// <summary>
    /// Retrieves player data from the IFPA API.
    /// </summary>
    /// <see href="https://www.ifpapinball.com/api/documentation/calendar/"/>
    public class CalendarApiClient : APIClientBase, ICalendarApiClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarApiClient"/> class.
        /// </summary>
        /// <param name="apiKey">Key needed to access API.</param>
        /// <param name="baseUri">The root of the API's url.</param>
        public CalendarApiClient(string apiKey, string baseUri)
            : base(apiKey, baseUri)
        {
        }

        /////// <summary>
        /////// Get a list of current calendar entries.
        /////// </summary>
        /////// <param name="country">Filter on a specific country.</param>
        /////// <returns>A calender list object.</returns>
        ////public CalendarListRoot GetActiveCalendarEntries(string country)
        ////{
        ////    var requestUri = this.BuildUri("calendar/active", $"&country={country}");
        ////    return this.GenericGet<CalendarListRoot>(requestUri);
        ////}

        /////// <summary>
        /////// Get a list of past calendar entries.
        /////// </summary>
        /////// <param name="country">Filter on a specific country.</param>
        /////// <returns>A calender list object.</returns>
        ////public CalendarListRoot GetPastCalendarEntries(string country)
        ////{
        ////    var requestUri = this.BuildUri("calendar/history", $"&country={country}");
        ////    return this.GenericGet<CalendarListRoot>(requestUri);
        ////}

        /// <summary>
        /// Get a list of past calendar entries.
        /// </summary>
        /// <param name="id">Calendar entry ID.</param>
        /// <returns>A calender list object.</returns>
        public CalendarEntryRoot GetCalendarEntry(int id)
        {
            var requestUri = this.BuildUri($"calendar/{id}", string.Empty);
            return this.GenericGet<CalendarEntryRoot>(requestUri);
        }

        /// <summary>
        /// Get data regarding a specific calendar entry.
        /// </summary>
        /// <param name="address">Filter on a specific country.</param>
        /// <param name="miles">The maximum miles from the address.</param>
        /// <returns>A calender list object.</returns>
        public CalendarSearchRoot GetCalendarSearch(string address, int miles)
        {
            address = System.Web.HttpUtility.UrlEncode(address);
            var requestUri = this.BuildUri("calendar/search", $"&address={address}&m={miles}");
            return this.GenericGet<CalendarSearchRoot>(requestUri);
        }
    }
}