namespace IFPAServicesTests
{
    using IFPAServices;
    using NUnit.Framework;

    public class RankingServiceTests : ServiceTestsBase
    {
        [Test]
        public void RankingService_GetRanking()
        {
            var result = rankingService.GetRanking();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.TotalCount, Is.EqualTo("8714"));
                Assert.That(result.SubCategory, Is.EqualTo(string.Empty));
            });
        }

        [Test]
        public void RankingService_GetRanking_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            rankingService = new RankingService(apiKey, baseUrl);

            var result = rankingService.GetRanking();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.TotalCount, Is.Null);
                Assert.That(result.SubCategory, Is.Null);
            });
        }

        [Test]
        public void RankingService_GetRanking_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            rankingService = new RankingService(apiKey, baseUrl);

            var result = rankingService.GetRanking();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.TotalCount, Is.Null);
                Assert.That(result.SubCategory, Is.Null);
            });
        }
    }
}
