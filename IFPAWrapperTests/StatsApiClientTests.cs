namespace IFPAWrapperTests
{
    using IFPAWrapper;
    using NUnit.Framework;

    public class StatsApiClientTests : ApiClientTestsBase
    {
        [Test]
        public void StatsApiClient_GetStatsPointsThisYear()
        {
            var result = statsApiClient.GetStatsPointsThisYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Points this Year"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsPointsThisYear_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsPointsThisYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsPointsThisYear_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsPointsThisYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsMostEvents()
        {
            var result = statsApiClient.GetStatsMostEvents();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsMostEvents_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsMostEvents();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsMostEvents_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsMostEvents();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsPlayersByCountry()
        {
            var result = statsApiClient.GetStatsPlayersByCountry();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Players by Country"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsPlayersByCountry_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsPlayersByCountry();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsPlayersByCountry_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsPlayersByCountry();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsEventsPerYear()
        {
            var result = statsApiClient.GetStatsEventsPerYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Events Per Year"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsEventsPerYear_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsEventsPerYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsEventsPerYear_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsEventsPerYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsPlayersByYear()
        {
            var result = statsApiClient.GetStatsPlayersByYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Players by Year"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsPlayersByYear_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsPlayersByYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsPlayersByYear_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsPlayersByYear();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsBiggestMovers()
        {
            var result = statsApiClient.GetStatsBiggestMovers();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.EqualTo("Biggest Mover this year (top 250)"));
                Assert.That(result.Stats, Is.Not.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsBiggestMovers_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsBiggestMovers();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }

        [Test]
        public void StatsApiClient_GetStatsBiggestMovers_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            statsApiClient = new StatsApiClient(apiKey, baseUrl);

            var result = statsApiClient.GetStatsBiggestMovers();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Type, Is.Null);
                Assert.That(result.Stats, Is.Null);
            });
        }
    }
}
