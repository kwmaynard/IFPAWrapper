// -----------------------------------------------------------------------
// <copyright file="PlayerSearchResult.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices.PlayerModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Add class summary.
    /// </summary>
    public class PlayerSearchResult : PlayerLocation
    {
        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("wppr_rank")]
        public string WpprRank { get; internal set; }
    }
}