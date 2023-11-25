// -----------------------------------------------------------------------
// <copyright file="TournamentRoot.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices.TournamentModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Add class summary.
    /// </summary>
    public class TournamentRoot
    {
        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("tournament")]
        public Tournament Tournament { get; internal set; }
    }
}