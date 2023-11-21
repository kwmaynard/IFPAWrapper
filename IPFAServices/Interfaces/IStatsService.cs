namespace IPFAServices
{
    using IPFAServices.StatModels;

    /// <summary>
    /// Allows various stats to be retrieved from the IPFA API.
    /// </summary>
    /// <see cref="https://www.ifpapinball.com/api/documentation/statistics/"/>
    public interface IStatsService
    {
        /// <summary>
        /// List of players who have earned the most points this year.
        /// </summary>
        /// <returns>A statistics object.</returns>
        StatsPointsThisYearRoot GetStatsPointsThisYear();

        /// <summary>
        /// List of players who have played in the most events the 3 years.
        /// </summary>
        /// <returns>A statistics object.</returns>
        StatsMostEventsRoot GetStatsMostEvents();

        /// <summary>
        /// Aggregate count of players by country.
        /// </summary>
        /// <returns>A statistics object.</returns>
        StatsPlayersByCountryRoot GetStatsPlayersByCountry();

        /// <summary>
        /// Aggregate event count by year.
        /// </summary>
        /// <returns>A statistics object.</returns>
        StatsEventsPerYearRoot GetStatsEventsPerYear();

        /// <summary>
        /// Aggregate players by year.
        /// </summary>
        /// <returns>A statistics object.</returns>
        StatsPlayersByYearRoot GetStatsPlayersByYear();

        /// <summary>
        /// Players who have moved the most positions since the beginning of the year (top 250).
        /// </summary>
        /// <returns>A statistics object.</returns>
        StatsBiggestMoversRoot GetStatsBiggestMovers();
    }
}