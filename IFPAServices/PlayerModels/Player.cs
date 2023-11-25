// -----------------------------------------------------------------------
// <copyright file="Player.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices.PlayerModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Add class summary.
    /// </summary>
    public class Player : PlayerLocation
    {
        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("initials")]
        public string Initials { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("age")]
        public int? Age { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("excluded_flag")]
        public string ExcludedFlag { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("ifpa_registered")]
        public string IfpaRegistered { get; internal set; }
    }
}