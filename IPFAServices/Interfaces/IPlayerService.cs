namespace IPFAServices
{
    using System.Net;
    using IPFAServices.PlayerModels;

    /// <summary>
    /// Retrieves player data from the IPFA API.
    /// </summary>
    /// <see cref="https://www.ifpapinball.com/api/documentation/player/"/>
    public interface IPlayerService
    {
        /// <summary>
        /// Use this enpoints to retrieve data about players.
        /// </summary>
        /// <param name="id">IPFA ID for the player.</param>
        /// <returns>A player object.</returns>
        PlayerRoot GetPlayer(int id);

        /// <summary>
        /// Get tournament results for a player.
        /// </summary>
        /// <param name="id">IPFA ID for the player.</param>
        /// <returns>A player results object.</returns>
        PlayerResultsRoot GetPlayerResults(int id);

        /// <summary>
        /// Get player comparisons for a specific player, at a high level. Note that this only brings back data if the player has played someone more than twice.
        /// </summary>
        /// <param name="id">IPFA ID for the player.</param>
        /// <returns>A player PVP object.</returns>
        PlayerPvpRoot GetPlayerPvp(int id);

        /// <summary>
        /// Get ranking and rating history for a player.
        /// </summary>
        /// <param name="id">IPFA ID for the player.</param>
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