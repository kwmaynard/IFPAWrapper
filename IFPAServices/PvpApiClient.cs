// -----------------------------------------------------------------------
// <copyright file="PvpService.cs" company="Valued Relationships, Inc.">
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
    public class PvpApiClient : APIClientBase, IPvpApiClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PvpApiClient"/> class.
        /// </summary>
        /// <param name="apiKey">Key needed to access API.</param>
        /// <param name="baseUri">The root of the API's url.</param>
        public PvpApiClient(string apiKey, string baseUri)
            : base(apiKey, baseUri)
        {
        }

        /// <summary>
        /// Get player and tournament information.
        /// </summary>
        /// <param name="p1id">IFPA ID for the first player.</param>
        /// <param name="p2id">IFPA ID for the second player.</param>
        /// <returns>A PVP object.</returns>
        public PvpRoot GetPlayer(int p1id, int p2id)
        {
            var requestUri = this.BuildUri("pvp", $"&p1={p1id}&p2={p2id}");
            return this.GenericGet<PvpRoot>(requestUri);
        }
    }
}