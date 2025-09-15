using System;
using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents the Amazing Race tournament details.
    /// </summary>
    public class AmazingRace
    {
        /// <summary>Gets or sets the tournament ID.</summary>
        public int TournamentId { get; set; }

        /// <summary>Gets or sets the tournament name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the tournament status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the tournament type.</summary>
        public string Type { get; set; }

        /// <summary>Gets or sets the UTC start time.</summary>
        public DateTime? StartUtc { get; set; }

        /// <summary>Gets or sets the local start time.</summary>
        public string StartLocal { get; set; }

        /// <summary>Gets or sets the UTC end time.</summary>
        public DateTime? EndUtc { get; set; }

        /// <summary>Gets or sets the local end time.</summary>
        public string EndLocal { get; set; }

        /// <summary>Gets or sets the completion time.</summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>Gets or sets the organizer ID.</summary>
        public int OrganizerId { get; set; }

        /// <summary>Gets or sets the location ID.</summary>
        public int? LocationId { get; set; }

        /// <summary>Gets or sets the series ID.</summary>
        public int? SeriesId { get; set; }

        /// <summary>Gets or sets the tournament description.</summary>
        public string Description { get; set; }

        /// <summary>Gets or sets the points map.</summary>
        public List<List<int>> PointsMap { get; set; }

        /// <summary>Gets or sets the tiebreaker points map.</summary>
        public List<List<string>> TiebreakerPointsMap { get; set; }

        /// <summary>Gets or sets a value indicating whether this is a test tournament.</summary>
        public bool Test { get; set; }

        /// <summary>Gets or sets the timezone.</summary>
        public string Timezone { get; set; }

        /// <summary>Gets or sets the scorekeeping method.</summary>
        public string Scorekeeping { get; set; }

        /// <summary>Gets or sets the tournament link.</summary>
        public string Link { get; set; }

        /// <summary>Gets or sets the linked tournament ID.</summary>
        public int? LinkedTournamentId { get; set; }

        /// <summary>Gets or sets the estimated TGP.</summary>
        public double? EstimatedTgp { get; set; }

        /// <summary>Gets or sets the organizer details.</summary>
        public Organizer Organizer { get; set; }

        /// <summary>Gets or sets the location details.</summary>
        public Location Location { get; set; }

        /// <summary>Gets or sets the seeding method.</summary>
        public string Seeding { get; set; }

        /// <summary>Gets or sets the first round pairing method.</summary>
        public string FirstRoundPairing { get; set; }

        /// <summary>Gets or sets the pairing method.</summary>
        public string Pairing { get; set; }

        /// <summary>Gets or sets the player order method.</summary>
        public string PlayerOrder { get; set; }

        /// <summary>Gets or sets the arena assignment method.</summary>
        public string ArenaAssignment { get; set; }

        /// <summary>Gets or sets the tournament duration.</summary>
        public int Duration { get; set; }

        /// <summary>Gets or sets the number of games per round.</summary>
        public int GamesPerRound { get; set; }

        /// <summary>Gets or sets the playoffs cutoff.</summary>
        public int PlayoffsCutoff { get; set; }

        /// <summary>Gets or sets tournament suggestions.</summary>
        public string Suggestions { get; set; }

        /// <summary>Gets or sets the tiebreaker method.</summary>
        public string Tiebreaker { get; set; }

        /// <summary>Gets or sets the scoring method.</summary>
        public string Scoring { get; set; }

        /// <summary>Gets or sets the list of rounds.</summary>
        public List<AmazingRaceRound> Rounds { get; set; }

        /// <summary>Gets or sets the list of games.</summary>
        public List<AmazingRaceGame> Games { get; set; }

        /// <summary>Gets or sets the list of queues.</summary>
        public List<AmazingRaceQueue> Queues { get; set; }
    }

    /// <summary>
    /// Represents the organizer of a tournament.
    /// </summary>
    public class Organizer
    {
        /// <summary>Gets or sets the user ID.</summary>
        public int UserId { get; set; }

        /// <summary>Gets or sets the organizer name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the IFPA ID (nullable).</summary>
        public int? IfpaId { get; set; }

        /// <summary>Gets or sets the organizer role.</summary>
        public string Role { get; set; }

        /// <summary>Gets or sets the flag.</summary>
        public string Flag { get; set; }

        /// <summary>Gets or sets the location.</summary>
        public string Location { get; set; }

        /// <summary>Gets or sets the pronouns.</summary>
        public string Pronouns { get; set; }

        /// <summary>Gets or sets the initials.</summary>
        public string Initials { get; set; }

        /// <summary>Gets or sets the avatar URL.</summary>
        public string Avatar { get; set; }

        /// <summary>Gets or sets the banner URL.</summary>
        public string Banner { get; set; }

        /// <summary>Gets or sets the tournament avatar URL.</summary>
        public string TournamentAvatar { get; set; }

        /// <summary>Gets or sets the creation date and time (nullable).</summary>
        public DateTime? CreatedAt { get; set; }
    }

    /// <summary>
    /// Represents the location of a tournament.
    /// </summary>
    public class Location
    {
        /// <summary>Gets or sets the location ID.</summary>
        public int LocationId { get; set; }

        /// <summary>Gets or sets the location name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the organizer ID (nullable).</summary>
        public int? OrganizerId { get; set; }

        /// <summary>Gets or sets the location status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the address.</summary>
        public string Address { get; set; }
    }

    /// <summary>
    /// Represents a round in the Amazing Race tournament.
    /// </summary>
    public class AmazingRaceRound
    {
        /// <summary>Gets or sets the round ID.</summary>
        public int RoundId { get; set; }

        /// <summary>Gets or sets the tournament ID.</summary>
        public int TournamentId { get; set; }

        /// <summary>Gets or sets the round name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the round status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the round index.</summary>
        public int Index { get; set; }

        /// <summary>Gets or sets the creation date and time (nullable).</summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>Gets or sets the completion date and time (nullable).</summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>Gets or sets the list of games in the round.</summary>
        public List<AmazingRaceGame> Games { get; set; }
    }

    /// <summary>
    /// Represents a game in the Amazing Race tournament.
    /// </summary>
    public class AmazingRaceGame
    {
        /// <summary>Gets or sets the game ID.</summary>
        public int GameId { get; set; }

        /// <summary>Gets or sets the round ID.</summary>
        public int RoundId { get; set; }

        /// <summary>Gets or sets the tournament ID.</summary>
        public int TournamentId { get; set; }

        /// <summary>Gets or sets the arena ID (nullable).</summary>
        public int? ArenaId { get; set; }

        /// <summary>Gets or sets the bank ID (nullable).</summary>
        public int? BankId { get; set; }

        /// <summary>Gets or sets the game index (nullable).</summary>
        public int? Index { get; set; }

        /// <summary>Gets or sets the set number (nullable).</summary>
        public int? Set { get; set; }

        /// <summary>Gets or sets the player ID with advantage (nullable).</summary>
        public int? PlayerIdAdvantage { get; set; }

        /// <summary>Gets or sets the scorekeeper ID (nullable).</summary>
        public int? ScorekeeperId { get; set; }

        /// <summary>Gets or sets the game status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the start date and time (nullable).</summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>Gets or sets the game duration (nullable).</summary>
        public int? Duration { get; set; }

        /// <summary>Gets or sets a value indicating whether this is a bye game.</summary>
        public bool Bye { get; set; }

        /// <summary>Gets or sets the list of player IDs.</summary>
        public List<int> PlayerIds { get; set; }

        /// <summary>Gets or sets the list of user IDs.</summary>
        public List<int> UserIds { get; set; }

        /// <summary>Gets or sets the result positions.</summary>
        public List<int> ResultPositions { get; set; }

        /// <summary>Gets or sets the result points.</summary>
        public List<string> ResultPoints { get; set; }

        /// <summary>Gets or sets the result scores (nullable).</summary>
        public List<int?> ResultScores { get; set; }

        /// <summary>Gets or sets the arena details.</summary>
        public AmazingRaceArena Arena { get; set; }

        /// <summary>Gets or sets the list of suggestions.</summary>
        public List<string> Suggestions { get; set; }
    }

    /// <summary>
    /// Represents a queue in the Amazing Race tournament.
    /// </summary>
    public class AmazingRaceQueue
    {
        /// <summary>Gets or sets the queue ID.</summary>
        public int QueueId { get; set; }

        /// <summary>Gets or sets the tournament ID.</summary>
        public int TournamentId { get; set; }

        /// <summary>Gets or sets the arena ID (nullable).</summary>
        public int? ArenaId { get; set; }

        /// <summary>Gets or sets the player ID (nullable).</summary>
        public int? PlayerId { get; set; }

        /// <summary>Gets or sets the position in the queue (nullable).</summary>
        public int? Position { get; set; }

        /// <summary>Gets or sets the creation date and time (nullable).</summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>Gets or sets the last update date and time (nullable).</summary>
        public DateTime? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents an arena in the Amazing Race tournament.
    /// </summary>
    public class AmazingRaceArena
    {
        /// <summary>Gets or sets the arena ID.</summary>
        public int ArenaId { get; set; }

        /// <summary>Gets or sets the arena name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the arena status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the OPDB ID.</summary>
        public string OpdbId { get; set; }

        /// <summary>Gets or sets the category ID (nullable).</summary>
        public int? CategoryId { get; set; }

        /// <summary>Gets or sets the organizer ID (nullable).</summary>
        public int? OrganizerId { get; set; }
    }
}