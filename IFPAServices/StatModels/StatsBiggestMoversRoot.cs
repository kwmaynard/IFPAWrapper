// -----------------------------------------------------------------------
// <copyright file="StatsBiggestMoversRoot.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices.StatModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Add class summary.
    /// </summary>
    public class StatsBiggestMoversRoot
    {
        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; internal set; }

        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("stats")]
        public List<StatsBiggestMovers> Stats { get; internal set; }
    }
}