namespace IPFAServices
{
    using IPFAServices.PlayerModels;

    /// <summary>
    /// Returns back information regarding the tournaments played between two players from the IPFA API.
    /// </summary>
    /// <see cref="https://www.ifpapinball.com/api/documentation/playervsplayer/"/>
    public interface IPvpService
    {
        /// <summary>
        /// Get player and tournament information.
        /// </summary>
        /// <param name="p1id">IPFA ID for the first player.</param>
        /// <param name="p2id">IPFA ID for the second player.</param>
        /// <returns>A PVP object.</returns>
        PvpRoot GetPlayer(int p1id, int p2id);
    }
}