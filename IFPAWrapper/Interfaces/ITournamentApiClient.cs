// -----------------------------------------------------------------------
// <copyright file="ITournamentService.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAWrapper
{
    using IFPAWrapper.TournamentModels;

    /// <summary>
    /// Retrieve data about tournaments from the IFPA API.
    /// </summary>
    /// <see href="https://www.ifpapinball.com/api/documentation/tournament/"/>
    public interface ITournamentApiClient
    {
        /// <summary>
        /// Get information about a tournament.
        /// </summary>
        /// <param name="id">IFPA ID for the tournament.</param>
        /// <returns>A tournament object.</returns>
        TournamentRoot GetTournament(int id);

        /// <summary>
        /// Get results for a tournament.
        /// </summary>
        /// <param name="id">IFPA ID for the tournament.</param>
        /// <returns>A tournament object.</returns>
        TournamentRoot GetTournamentResults(int id);

        /// <summary>
        /// Get a high level list of tournaments.
        /// </summary>
        /// <param name="startPos">Start at a specific point in the list. Default is 1.</param>
        /// <param name="count">Number of records to return. Max is 250.</param>
        /// <returns>A list of tournaments.</returns>
        TournamentListRoot GetTournamentList(int startPos, int count);

        /// <summary>
        /// Search for a tournament by name.
        /// </summary>
        /// <param name="name">Partial name of the tournaments.</param>
        /// <returns>A list of tournaments.</returns>
        TournamentSearchRoot GetTournamentSearch(string name);
    }
}