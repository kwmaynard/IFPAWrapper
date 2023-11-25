// -----------------------------------------------------------------------
// <copyright file="PlayerResultsRoot.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices.PlayerModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Add class summary.
    /// </summary>
    public class PlayerResultsRoot
    {
        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("player_id")]
        public int? PlayerId { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("results_count")]
        public int? ResultsCount { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("results")]
        public List<EventResult> Results { get; internal set; }
    }
}