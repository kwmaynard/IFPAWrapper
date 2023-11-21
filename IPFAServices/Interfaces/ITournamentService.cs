namespace IPFAServices
{
    using IPFAServices.TournamentModels;

    /// <summary>
    /// Retrieve data about tournaments from the IPFA API.
    /// </summary>
    /// <see cref="https://www.ifpapinball.com/api/documentation/tournament/"/>
    public interface ITournamentService
    { 
        /// <summary>
        /// Get information about a tournament.
        /// </summary>
        /// <param name="id">IPFA ID for the tournament.</param>
        /// <returns>A tournament object.</returns>
         TournamentRoot GetTournament(int id);

    /// <summary>
    /// Get results for a tournament.
    /// </summary>
    /// <param name="id">IPFA ID for the tournament.</param>
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