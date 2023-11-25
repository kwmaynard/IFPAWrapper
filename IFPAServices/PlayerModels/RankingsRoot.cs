// -----------------------------------------------------------------------
// <copyright file="RankingsRoot.cs" company="Valued Relationships, Inc.">
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
    public class RankingsRoot
    {
        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("total_count")]
        public string TotalCount { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("sub_category")]
        public string SubCategory { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("rankings")]
        public List<Ranking> Rankings { get; internal set; }
    }
}