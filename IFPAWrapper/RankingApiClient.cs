// -----------------------------------------------------------------------
// <copyright file="RankingService.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices
{
    using IFPAServices.PlayerModels;

    /// <summary>
    /// Retrieve data about the WPPR rankings from the IFPA API.
    /// </summary>
    /// <see href="https://www.ifpapinball.com/api/documentation/rankings/"/>
    public class RankingApiClient : APIClientBase, IRankingApiClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankingApiClient"/> class.
        /// </summary>
        /// <param name="apiKey">Key needed to access API.</param>
        /// <param name="baseUri">The root of the API's url.</param>
        public RankingApiClient(string apiKey, string baseUri)
            : base(apiKey, baseUri)
        {
        }

        /// <summary>
        /// Get the WPPR rankings.
        /// </summary>
        /// <param name="startPos">Start at a specific point in the list. Default is 1.</param>
        /// <param name="count">Number of records to return. Default is 50.</param>
        /// <param name="sortOrder">Order the results. Options: points, rating, eff_pct. Default is points.</param>
        /// <returns>A list of rankings.</returns>
        public RankingsRoot GetRanking(int startPos = 1, int count = 50, string sortOrder = "points")
        {
            var requestUri = this.BuildUri("rankings", $"&start_pos={startPos}&count={count}&order={sortOrder}");
            return this.GenericGet<RankingsRoot>(requestUri);
        }
    }
}