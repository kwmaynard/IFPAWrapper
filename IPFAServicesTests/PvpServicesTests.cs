namespace IPFAServicesTests
{
    using IPFAServices;
    using NUnit.Framework;

    public class Tests
    {
        private string apiKey;
        private string baseUrl;
        private PvpService service;

        [SetUp]
        public void Setup()
        {
            apiKey = "{apikey}";
            baseUrl = "https://api.ifpapinball.com/v1";
            service = new PvpService(apiKey, baseUrl);
        }

        [Test]
        public void PvpService_GetPlayer_1_2()
        {
            var player1Id = 1;
            var player2Id = 2;

            var result = service.GetPlayer(player1Id, player2Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Pvp, Is.Not.Null);
        }

        [Test]
        public void PvpService_GetPlayer_0_0()
        {
            var player1Id = 0;
            var player2Id = 0;

            var result = service.GetPlayer(player1Id, player2Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Pvp, Is.Null);
        }
    }
}