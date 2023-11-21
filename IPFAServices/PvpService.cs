namespace IPFAServices
{
    using IPFAServices.PlayerModels;

    /// <summary>
    /// Returns back information regarding the tournaments played between two players from the IPFA API.
    /// </summary>
    /// <see cref="https://www.ifpapinball.com/api/documentation/playervsplayer/"/>
    public class PvpService : ServiceBase, IPvpService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PvpService"/> class.
        /// </summary>
        /// <param name="apiKey">Key needed to access API</param>
        /// <param name="baseUri">The root of the API's url.</param>
        public PvpService(string apiKey, string baseUri)
            : base(apiKey, baseUri)
        {
        }

        /// <summary>
        /// Get player and tournament information.
        /// </summary>
        /// <param name="p1id">IPFA ID for the first player.</param>
        /// <param name="p2id">IPFA ID for the second player.</param>
        /// <returns>A PVP object.</returns>
        public PvpRoot GetPlayer(int p1id, int p2id)
        {
            var requestUri = this.BuildUri("pvp", $"&p1={p1id}&p2={p2id}");
            return this.GenericGet<PvpRoot>(requestUri);
        }
    }
}