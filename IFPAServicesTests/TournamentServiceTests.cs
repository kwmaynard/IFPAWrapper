namespace IFPAServicesTests
{
    using IFPAServices;
    using NUnit.Framework;

    public class TournamentServiceTests : ServiceTestsBase
    {
        [Test]
        public void TournamentServiceTests_GetTournament_0()
        {
            var tournamentId = 0;

            var result = tournamentService.GetTournament(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournament_0_BadKey()
        {
            var tournamentId = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournament(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournament_0_BadUrl()
        {
            var tournamentId = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournament(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournament_64056()
        {
            var tournamentId = 64056;

            var result = tournamentService.GetTournament(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Not.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournament_64056_BadKey()
        {
            var tournamentId = 64056;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournament(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournament_64056_BadUrl()
        {
            var tournamentId = 64056;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournament(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournamentResults_0()
        {
            var tournamentId = 0;

            var result = tournamentService.GetTournamentResults(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournamentResults_0_BadKey()
        {
            var tournamentId = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentResults(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournamentResults_0_BadUrl()
        {
            var tournamentId = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentResults(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournamentResults_64056()
        {
            var tournamentId = 64056;

            var result = tournamentService.GetTournamentResults(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Not.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournamentResults_64056_BadKey()
        {
            var tournamentId = 64056;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentResults(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournamentResults_64056_BadUrl()
        {
            var tournamentId = 64056;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentResults(tournamentId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Tournament, Is.Null);
        }

        [Test]
        public void TournamentServiceTests_GetTournamentList_50_10()
        {
            var start = 50;
            var count = 10;

            var result = tournamentService.GetTournamentList(start, count);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Not.Null);
                Assert.That(result.TotalResults, Is.EqualTo("55277"));
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentList_50_10_BadKey()
        {
            var start = 50;
            var count = 10;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentList(start, count);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
                Assert.That(result.TotalResults, Is.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentList_50_10_BadUrl()
        {
            var start = 50;
            var count = 10;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentList(start, count);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
                Assert.That(result.TotalResults, Is.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentSearch_silverball()
        {
            var partialName = "silverball";

            var result = tournamentService.GetTournamentSearch(partialName);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Not.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentSearch_silverball_BadKey()
        {
            var partialName = "silverball";

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentSearch(partialName);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentSearch_silverball_BadUrl()
        {
            var partialName = "silverball";

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentSearch(partialName);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentSearch_gibberish()
        {
            var partialName = "gibberish";

            var result = tournamentService.GetTournamentSearch(partialName);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentSearch_gibberish_BadKey()
        {
            var partialName = "gibberish";

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentSearch(partialName);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentSearch_gibberish_BadUrl()
        {
            var partialName = "gibberish";

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentSearch(partialName);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentSearch_empty()
        {
            var partialName = string.Empty;

            var result = tournamentService.GetTournamentSearch(partialName);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentSearch_empty_BadKey()
        {
            var partialName = string.Empty;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentSearch(partialName);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
            });
        }

        [Test]
        public void TournamentServiceTests_GetTournamentSearch_empty_BadUrl()
        {
            var partialName = string.Empty;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            tournamentService = new TournamentService(apiKey, baseUrl);

            var result = tournamentService.GetTournamentSearch(partialName);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Tournament, Is.Null);
            });
        }
    }
}