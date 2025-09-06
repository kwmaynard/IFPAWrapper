// -----------------------------------------------------------------------
// <copyright file="StatsService.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices
{
    using IFPAServices.StatModels;

    /// <summary>
    /// Allows various stats to be retrieved from the IFPA API.
    /// </summary>
    /// <see href="https://www.ifpapinball.com/api/documentation/statistics/"/>
    public class StatsApiClient : APIClientBase, IStatsApiClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatsApiClient"/> class.
        /// </summary>
        /// <param name="apiKey">Key needed to access API.</param>
        /// <param name="baseUri">The root of the API's url.</param>
        public StatsApiClient(string apiKey, string baseUri)
            : base(apiKey, baseUri)
        {
        }

        /// <summary>
        /// List of players who have earned the most points this year.
        /// </summary>
        /// <returns>A statistics object.</returns>
        public StatsPointsThisYearRoot GetStatsPointsThisYear()
        {
            var requestUri = this.BuildUri("stats/points_this_year", string.Empty);
            return this.GenericGet<StatsPointsThisYearRoot>(requestUri);
        }

        /// <summary>
        /// List of players who have played in the most events the 3 years.
        /// </summary>
        /// <returns>A statistics object.</returns>
        public StatsMostEventsRoot GetStatsMostEvents()
        {
            var requestUri = this.BuildUri("stats/most_events", string.Empty);
            return this.GenericGet<StatsMostEventsRoot>(requestUri);
        }

        /// <summary>
        /// Aggregate count of players by country.
        /// </summary>
        /// <returns>A statistics object.</returns>
        public StatsPlayersByCountryRoot GetStatsPlayersByCountry()
        {
            var requestUri = this.BuildUri("stats/country_players", string.Empty);
            return this.GenericGet<StatsPlayersByCountryRoot>(requestUri);
        }

        /// <summary>
        /// Aggregate event count by year.
        /// </summary>
        /// <returns>A statistics object.</returns>
        public StatsEventsPerYearRoot GetStatsEventsPerYear()
        {
            var requestUri = this.BuildUri("stats/events_by_year", string.Empty);
            return this.GenericGet<StatsEventsPerYearRoot>(requestUri);
        }

        /// <summary>
        /// Aggregate players by year.
        /// </summary>
        /// <returns>A statistics object.</returns>
        public StatsPlayersByYearRoot GetStatsPlayersByYear()
        {
            var requestUri = this.BuildUri("stats/players_by_year", string.Empty);
            return this.GenericGet<StatsPlayersByYearRoot>(requestUri);
        }

        /// <summary>
        /// Players who have moved the most positions since the beginning of the year (top 250).
        /// </summary>
        /// <returns>A statistics object.</returns>
        public StatsBiggestMoversRoot GetStatsBiggestMovers()
        {
            var requestUri = this.BuildUri("stats/biggest_movers", string.Empty);
            return this.GenericGet<StatsBiggestMoversRoot>(requestUri);
        }
    }
}