namespace IFPAWrapperTests
{
    using IFPAWrapper;
    using NUnit.Framework;

    public class CalendarApiClientTests : ApiClientTestsBase
    {
        [Test]
        public void CalendarApiClientTests_GetCalendarEntry_0()
        {
            var tournamentId = 0;

            var result = calendarApiClient.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarApiClientTests_GetCalendarEntry_0_BadKey()
        {
            var tournamentId = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            calendarApiClient = new CalendarApiClient(apiKey, baseUrl);

            var result = calendarApiClient.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarApiClientTests_GetCalendarEntry_0_BadUrl()
        {
            var tournamentId = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            calendarApiClient = new CalendarApiClient(apiKey, baseUrl);

            var result = calendarApiClient.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarApiClientTests_GetCalendarEntry_64056()
        {
            var tournamentId = 64056;

            var result = calendarApiClient.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Not.Null);
        }

        [Test]
        public void CalendarApiClientTests_GetCalendarEntry_64056_BadKey()
        {
            var tournamentId = 64056;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            calendarApiClient = new CalendarApiClient(apiKey, baseUrl);

            var result = calendarApiClient.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarApiClientTests_GetCalendarEntry_64056_BadUrl()
        {
            var tournamentId = 64056;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            calendarApiClient = new CalendarApiClient(apiKey, baseUrl);

            var result = calendarApiClient.GetCalendarEntry(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Null);
        }

        [Test]
        public void CalendarApiClientTests_GetCalendarSearch()
        {
            var address = "8000 Anderson Park Ln Westerville OH 43081";
            var miles = 50;
 
            var result = calendarApiClient.GetCalendarSearch(address, miles);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Calendar, Is.Not.Null);
            Assert.That(result.TotalEntries, Is.GreaterThan(0));
        }
    }
}
