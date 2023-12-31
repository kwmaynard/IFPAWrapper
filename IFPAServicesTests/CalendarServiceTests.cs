﻿namespace IFPAServicesTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using IFPAServices;
    using NUnit.Framework;

    public class CalendarServiceTests : ServiceTestsBase
    {
        [Test]
        public void CalendarServiceTests_GetCalendarEntry_0()
        {
            var tournamentId = 0;

            var result = calendarService.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarServiceTests_GetCalendarEntry_0_BadKey()
        {
            var tournamentId = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            calendarService = new CalendarService(apiKey, baseUrl);

            var result = calendarService.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarServiceTests_GetCalendarEntry_0_BadUrl()
        {
            var tournamentId = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            calendarService = new CalendarService(apiKey, baseUrl);

            var result = calendarService.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarServiceTests_GetCalendarEntry_64056()
        {
            var tournamentId = 64056;

            var result = calendarService.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Not.Null);
        }

        [Test]
        public void CalendarServiceTests_GetCalendarEntry_64056_BadKey()
        {
            var tournamentId = 64056;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            calendarService = new CalendarService(apiKey, baseUrl);

            var result = calendarService.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarServiceTests_GetCalendarEntry_64056_BadUrl()
        {
            var tournamentId = 64056;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            calendarService = new CalendarService(apiKey, baseUrl);

            var result = calendarService.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarServiceTests_GetCalendarSearch()
        {
            var address = "8000 Anderson Park Ln Westerville OH 43081";
            var miles = 50;
 
            var result = calendarService.GetCalendarSearch(address, miles);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Not.Null);
            Assert.That(result.TotalEntries, Is.GreaterThan(0));
        }
    }
}
