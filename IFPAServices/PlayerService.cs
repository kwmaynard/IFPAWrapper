// -----------------------------------------------------------------------
// <copyright file="PlayerService.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices
{
    using IFPAServices.PlayerModels;

    /// <summary>
    /// Retrieves player data from the IFPA API.
    /// </summary>
    /// <see href="https://www.ifpapinball.com/api/documentation/player/"/>
    public class PlayerService : ServiceBase, IPlayerService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerService"/> class.
        /// </summary>
        /// <param name="apiKey">Key needed to access API.</param>
        /// <param name="baseUri">The root of the API's url.</param>
        public PlayerService(string apiKey, string baseUri)
            : base(apiKey, baseUri)
        {
        }

        /// <summary>
        /// Use this enpoints to retrieve data about players.
        /// </summary>
        /// <param name="id">IFPA ID for the player.</param>
        /// <returns>A player object.</returns>
        public PlayerRoot GetPlayer(int id)
        {
            var requestUri = this.BuildUri($"player/{id}", string.Empty);
            return this.GenericGet<PlayerRoot>(requestUri);
        }

        /// <summary>
        /// Get tournament results for a player.
        /// </summary>
        /// <param name="id">IFPA ID for the player.</param>
        /// <returns>A player results object.</returns>
        public PlayerResultsRoot GetPlayerResults(int id)
        {
            var requestUri = this.BuildUri($"player/{id}/results", string.Empty);
            return this.GenericGet<PlayerResultsRoot>(requestUri);
        }

        /// <summary>
        /// Get player comparisons for a specific player, at a high level. Note that this only brings back data if the player has played someone more than twice.
        /// </summary>
        /// <param name="id">IFPA ID for the player.</param>
        /// <returns>A player PVP object.</returns>
        public PlayerPvpRoot GetPlayerPvp(int id)
        {
            var requestUri = this.BuildUri($"player/{id}/pvp", string.Empty);
            return this.GenericGet<PlayerPvpRoot>(requestUri);
        }

        /// <summary>
        /// Get ranking and rating history for a player.
        /// </summary>
        /// <param name="id">IFPA ID for the player.</param>
        /// <returns>A player history object.</returns>
        public PlayerHistoryRoot GetPlayerHistory(int id)
        {
            var requestUri = this.BuildUri($"player/{id}/history", string.Empty);
            return this.GenericGet<PlayerHistoryRoot>(requestUri);
        }

        /// <summary>
        /// Get a list of country directors.
        /// </summary>
        /// <returns>A country director search results object.</returns>
        public CountryDirectorRoot GetCountryDirectors()
        {
            var requestUri = this.BuildUri("player/country_directors", string.Empty);
            return this.GenericGet<CountryDirectorRoot>(requestUri);
        }

        /// <summary>
        /// Search for players by name.
        /// </summary>
        /// <param name="name">The player's name.</param>
        /// <returns>A player search results object.</returns>
        public PlayerSearchRoot GetPlayers(string name)
        {
            var requestUri = this.BuildUri("player/search", $"&q={name}");
            return this.GenericGet<PlayerSearchRoot>(requestUri);
        }
    }
}