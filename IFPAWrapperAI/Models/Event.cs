using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
    /// <summary>
    /// TODO: Add class summary.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("event_date")]
        public string EventDate { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("winner_player_id")]
        public string WinnerPlayerId { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("winner_first_name")]
        public string WinnerFirstName { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("winner_last_name")]
        public string WinnerLastName { get; internal set; }
    }
}