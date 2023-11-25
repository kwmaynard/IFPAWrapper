// -----------------------------------------------------------------------
// <copyright file="ICalendarService.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices
{
    using IFPAServices.CalendarModels;

    /// <summary>
    /// Get data from the calendar from the IFPA API.
    /// </summary>
    /// <see href="https://www.ifpapinball.com/api/documentation/calendar/"/>
    public interface ICalendarService
    {
        /////// <summary>
        /////// Get a list of current calendar entries.
        /////// </summary>
        /////// <param name="country">Filter on a specific country.</param>
        /////// <returns>A calender list object.</returns>
        ////CalendarListRoot GetActiveCalendarEntries(string country);

        /////// <summary>
        /////// Get a list of past calendar entries.
        /////// </summary>
        /////// <param name="country">Filter on a specific country.</param>
        /////// <returns>A calender list object.</returns>
        ////CalendarListRoot GetPastCalendarEntries(string country);

        /// <summary>
        /// Get a list of past calendar entries.
        /// </summary>
        /// <param name="id">Calendar entry ID.</param>
        /// <returns>A calender list object.</returns>
        CalendarEntryRoot GetCalendarEntry(int id);

        /// <summary>
        /// Get a list of calendar entries near an address.
        /// </summary>
        /// <param name="address">Filter on a specific country.</param>
        /// <param name="miles">The maximum miles from the address.</param>
        /// <returns>A calender list object.</returns>
        CalendarSearchRoot GetCalendarSearch(string address, int miles);
    }
}