// -----------------------------------------------------------------------
// <copyright file="TournamentResult.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices.TournamentModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Add class summary.
    /// </summary>
    public class TournamentResult
    {
        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("player_id")]
        public string PlayerId { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("wppr_rank")]
        public string WpprRank { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("ratings_value")]
        public string RatingsValue { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("points")]
        public string Points { get; internal set; }
    }
}