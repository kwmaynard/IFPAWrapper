﻿namespace IPFAServices
{
    using IPFAServices.PlayerModels;

    /// <summary>
    /// Retrieve data about the WPPR rankings from the IPFA API.
    /// </summary>
    /// <see cref="https://www.ifpapinball.com/api/documentation/rankings/"/>
    public interface IRankingService
    {
        /// <summary>
        /// Get the WPPR rankings.
        /// </summary>
        /// <param name="startPos">Start at a specific point in the list. Default is 1.</param>
        /// <param name="count">Number of records to return. Default is 50.</param>
        /// <param name="sortOrder">Order the results. Options: points, rating, eff_pct. Default is points.</param>
        /// <returns>A list of rankings.</returns>
        RankingsRoot GetRanking(int startPos = 1, int count = 50, string sortOrder = "points");
    }
}