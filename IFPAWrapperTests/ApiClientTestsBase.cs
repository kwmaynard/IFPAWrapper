namespace IFPAServicesTests
{
    using IFPAServices;
    using NUnit.Framework;

    public abstract class ApiClientTestsBase
    {
        protected string apiKey;
        protected string baseUrl;
        protected CalendarApiClient calendarApiClient;
        protected PlayerApiClient playerApiClient;
        protected PvpApiClient pvpApiClient;
        protected RankingApiClient rankingApiClient;
        protected StatsApiClient statsApiClient;
        protected TournamentApiClient tournamentApiClient;

        [SetUp]
        public void Setup()
        {
            apiKey = "{apiKey}";
            baseUrl = "https://api.ifpapinball.com/v1";
            calendarApiClient = new CalendarApiClient(apiKey, baseUrl);
            playerApiClient = new PlayerApiClient(apiKey, baseUrl);
            pvpApiClient = new PvpApiClient(apiKey, baseUrl);
            rankingApiClient = new RankingApiClient(apiKey, baseUrl);
            statsApiClient = new StatsApiClient(apiKey, baseUrl);
            tournamentApiClient = new TournamentApiClient(apiKey, baseUrl);
        }
    }
}