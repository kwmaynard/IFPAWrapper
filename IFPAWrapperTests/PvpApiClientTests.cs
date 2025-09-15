namespace IFPAWrapperTests
{
    using IFPAWrapper;
    using NUnit.Framework;

    public class PvpApiClientTests : ApiClientTestsBase
    {
        [Test]
        public void PvpApiClient_GetPlayer_1_2()
        {
            var player1Id = 1;
            var player2Id = 2;

            var result = pvpApiClient.GetPlayer(player1Id, player2Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Pvp, Is.Not.Null);
        }

        [Test]
        public void PvpApiClient_GetPlayer_0_0()
        {
            var player1Id = 0;
            var player2Id = 0;

            var result = pvpApiClient.GetPlayer(player1Id, player2Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Pvp, Is.Null);
        }

        [Test]
        public void PvpApiClient_GetPlayer_1_2_BadKey()
        {
            var player1Id = 1;
            var player2Id = 2;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            pvpApiClient = new PvpApiClient(apiKey, baseUrl);

            var result = pvpApiClient.GetPlayer(player1Id, player2Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Pvp, Is.Null);
        }

        [Test]
        public void PvpApiClient_GetPlayer_0_0_BadKey()
        {
            var player1Id = 0;
            var player2Id = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            pvpApiClient = new PvpApiClient(apiKey, baseUrl);

            var result = pvpApiClient.GetPlayer(player1Id, player2Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Pvp, Is.Null);
        }

        [Test]
        public void PvpApiClient_GetPlayer_1_2_BadKey_BadUrl()
        {
            var player1Id = 1;
            var player2Id = 2;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            pvpApiClient = new PvpApiClient(apiKey, baseUrl);

            var result = pvpApiClient.GetPlayer(player1Id, player2Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Pvp, Is.Null);
        }

        [Test]
        public void PvpApiClient_GetPlayer_0_0_BadKey_BadUrl()
        {
            var player1Id = 0;
            var player2Id = 0;

            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            pvpApiClient = new PvpApiClient(apiKey, baseUrl);

            var result = pvpApiClient.GetPlayer(player1Id, player2Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Pvp, Is.Null);
        }
    }
}