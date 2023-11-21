namespace IPFAServices
{
    using IPFAServices.TournamentModels;

    /// <summary>
    /// Retrieve data about tournaments from the IPFA API.
    /// </summary>
    /// <see cref="https://www.ifpapinball.com/api/documentation/tournament/"/>
    public class TournamentService : ServiceBase, ITournamentService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentService"/> class.
        /// </summary>
        /// <param name="apiKey">Key needed to access API</param>
        /// <param name="baseUri">The root of the API's url.</param>
        public TournamentService(string apiKey, string baseUri)
            : base(apiKey, baseUri)
        {
        }

        /// <summary>
        /// Get information about a tournament.
        /// </summary>
        /// <param name="id">IPFA ID for the tournament.</param>
        /// <returns>A tournament object.</returns>
        public TournamentRoot GetTournament(int id)
        {
            var requestUri = this.BuildUri($"tournament/{id}", string.Empty);
            return this.GenericGet<TournamentRoot>(requestUri);
        }

        /// <summary>
        /// Get results for a tournament.
        /// </summary>
        /// <param name="id">IPFA ID for the tournament.</param>
        /// <returns>A tournament object.</returns>
        public TournamentRoot GetTournamentResults(int id)
        {
            var requestUri = this.BuildUri($"tournament/{id}/results", string.Empty);
            return this.GenericGet<TournamentRoot>(requestUri);
        }

        /// <summary>
        /// Get a high level list of tournaments.
        /// </summary>
        /// <param name="startPos">Start at a specific point in the list. Default is 1.</param>
        /// <param name="count">Number of records to return. Max is 250.</param>
        /// <returns>A list of tournaments.</returns>
        public TournamentListRoot GetTournamentList(int startPos, int count)
        {
            var requestUri = this.BuildUri("tournament/list", $"&start_pos={startPos}&count={count}");
            return this.GenericGet<TournamentListRoot>(requestUri);
        }

        /// <summary>
        /// Search for a tournament by name.
        /// </summary>
        /// <param name="name">Partial name of the tournaments.</param>
        /// <returns>A list of tournaments.</returns>
        public TournamentSearchRoot GetTournamentSearch(string name)
        {
            var requestUri = this.BuildUri("tournament/search", $"&q={name}");
            return this.GenericGet<TournamentSearchRoot>(requestUri);
        }
    }
}