// -----------------------------------------------------------------------
// <copyright file="IPlayerService.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAWrapper
{
    using System.Net;
    using IFPAWrapper.PlayerModels;

    /// <summary>
    /// Retrieves player data from the IFPA API.
    /// </summary>
    /// <see href="https://www.ifpapinball.com/api/documentation/player/"/>
    public interface IPlayerApiClient
    {
        /// <summary>
        /// Use this enpoints to retrieve data about players.
        /// </summary>
        /// <param name="id">IFPA ID for the player.</param>
        /// <returns>A player object.</returns>
        PlayerRoot GetPlayer(int id);

        /// <summary>
        /// Get tournament results for a player.
        /// </summary>
        /// <param name="id">IFPA ID for the player.</param>
        /// <returns>A player results object.</returns>
        PlayerResultsRoot GetPlayerResults(int id);

        /// <summary>
        /// Get player comparisons for a specific player, at a high level. Note that this only brings back data if the player has played someone more than twice.
        /// </summary>
        /// <param name="id">IFPA ID for the player.</param>
        /// <returns>A player PVP object.</returns>
        PlayerPvpRoot GetPlayerPvp(int id);

        /// <summary>
        /// Get ranking and rating history for a player.
        /// </summary>
        /// <param name="id">IFPA ID for the player.</param>
        /// <returns>A player history object.</returns>
        PlayerHistoryRoot GetPlayerHistory(int id);

        /// <summary>
        /// Get a list of country directors.
        /// </summary>
        /// <returns>A country director search results object.</returns>
        CountryDirectorRoot GetCountryDirectors();

        /// <summary>
        /// Search for players by name.
        /// </summary>
        /// <param name="name">The player's name.</param>
        /// <returns>A player search results object.</returns>
        PlayerSearchRoot GetPlayers(string name);
    }
}