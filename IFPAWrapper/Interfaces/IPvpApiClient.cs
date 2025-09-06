// -----------------------------------------------------------------------
// <copyright file="IPvpService.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices
{
    using IFPAServices.PlayerModels;

    /// <summary>
    /// Returns back information regarding the tournaments played between two players from the IFPA API.
    /// </summary>
    /// <see href="https://www.ifpapinball.com/api/documentation/playervsplayer/"/>
    public interface IPvpApiClient
    {
        /// <summary>
        /// Get player and tournament information.
        /// </summary>
        /// <param name="p1id">IFPA ID for the first player.</param>
        /// <param name="p2id">IFPA ID for the second player.</param>
        /// <returns>A PVP object.</returns>
        PvpRoot GetPlayer(int p1id, int p2id);
    }
}