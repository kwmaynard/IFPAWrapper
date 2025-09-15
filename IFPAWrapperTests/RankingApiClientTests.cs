namespace IFPAWrapperTests
{
    using IFPAWrapper;
    using NUnit.Framework;

    public class RankingApiClientTests : ApiClientTestsBase
    {
        [Test]
        public void RankingApiClient_GetRanking()
        {
            var result = rankingApiClient.GetRanking();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.TotalCount, Is.EqualTo("8714"));
                Assert.That(result.SubCategory, Is.EqualTo(string.Empty));
            });
        }

        [Test]
        public void RankingApiClient_GetRanking_BadKey()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v1";
            rankingApiClient = new RankingApiClient(apiKey, baseUrl);

            var result = rankingApiClient.GetRanking();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.TotalCount, Is.Null);
                Assert.That(result.SubCategory, Is.Null);
            });
        }

        [Test]
        public void RankingApiClient_GetRanking_BadKey_BadUrl()
        {
            apiKey = "gibberish";
            baseUrl = "https://api.ifpapinball.com/v0";
            rankingApiClient = new RankingApiClient(apiKey, baseUrl);

            var result = rankingApiClient.GetRanking();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.TotalCount, Is.Null);
                Assert.That(result.SubCategory, Is.Null);
            });
        }
    }
}
