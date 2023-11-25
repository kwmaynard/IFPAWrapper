namespace IFPAServicesTests
{
    using IFPAServices;
    using NUnit.Framework;

    public class ServiceTestsBase
    {
        protected string apiKey;
        protected string baseUrl;
        protected CalendarService calendarService;
        protected PlayerService playerService;
        protected PvpService pvpService;
        protected RankingService rankingService;
        protected StatsService statsService;
        protected TournamentService tournamentService;

        [SetUp]
        public void Setup()
        {
            apiKey = "2533965fe7182ffd4153b6124a20c386";
            baseUrl = "https://api.ifpapinball.com/v1";
            calendarService = new CalendarService(apiKey, baseUrl);
            playerService = new PlayerService(apiKey, baseUrl);
            pvpService = new PvpService(apiKey, baseUrl);
            rankingService = new RankingService(apiKey, baseUrl);
            statsService = new StatsService(apiKey, baseUrl);
            tournamentService = new TournamentService(apiKey, baseUrl);
        }
    }
}