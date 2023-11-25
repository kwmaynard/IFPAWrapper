namespace IFPAServicesTests
{
    using IFPAServices;
    using NUnit.Framework;

    public class StatsServiceTests : ServiceTestsBase
    {
        [Test]
        public void StatsService_GetStatsPointsThisYear()
        {
            var result = statsService.GetStatsPointsThisYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Points this Year"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsPointsThisYear_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsPointsThisYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsPointsThisYear_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsPointsThisYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsMostEvents()
        {
            var result = statsService.GetStatsMostEvents();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsMostEvents_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsMostEvents();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsMostEvents_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsMostEvents();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsPlayersByCountry()
        {
            var result = statsService.GetStatsPlayersByCountry();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Players by Country"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsPlayersByCountry_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsPlayersByCountry();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsPlayersByCountry_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsPlayersByCountry();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsEventsPerYear()
        {
            var result = statsService.GetStatsEventsPerYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Events Per Year"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsEventsPerYear_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsEventsPerYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsEventsPerYear_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsEventsPerYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsPlayersByYear()
        {
            var result = statsService.GetStatsPlayersByYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Players by Year"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsPlayersByYear_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsPlayersByYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsPlayersByYear_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsPlayersByYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsBiggestMovers()
        {
            var result = statsService.GetStatsBiggestMovers();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Biggest Mover this year (top 250)"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsBiggestMovers_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsBiggestMovers();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsService_GetStatsBiggestMovers_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsService = new StatsService(apiKey, baseUrl);

            var result = statsService.GetStatsBiggestMovers();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }
    }
}
