using System;
using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents matchplay statistics for a tournament.
    /// </summary>
    public class MatchplayStats
    {
        /// <summary>Gets or sets the list of position counts for players.</summary>
        public List<PositionCount> PositionCounts { get; set; }
        /// <summary>Gets or sets the list of arena counts for players.</summary>
        public List<ArenaCount> ArenaCounts { get; set; }
        /// <summary>Gets or sets the list of opponent counts for players.</summary>
        public List<OpponentCount> OpponentCounts { get; set; }
    }

    /// <summary>
    /// Represents the count of positions for a player.
    /// </summary>
    public class PositionCount
    {
        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }
        /// <summary>Gets or sets the dictionary of position counts (position -> count).</summary>
        public Dictionary<int, int> Positions { get; set; }
    }

    /// <summary>
    /// Represents the count of arenas for a player.
    /// </summary>
    public class ArenaCount
    {
        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }
        /// <summary>Gets or sets the dictionary of arena counts (arena ID -> count).</summary>
        public Dictionary<int, int> Arenas { get; set; }
    }

    /// <summary>
    /// Represents the count of opponents for a player.
    /// </summary>
    public class OpponentCount
    {
        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }
        /// <summary>Gets or sets the dictionary of opponent counts (opponent ID -> count).</summary>
        public Dictionary<int, int> Opponents { get; set; }
    }
}
