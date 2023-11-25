// -----------------------------------------------------------------------
// <copyright file="CalendarEntryRoot.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices.CalendarModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Add class summary.
    /// </summary>
    public class CalendarEntryRoot
    {
        /// <summary>
        /// Gets TODO: Add property summary.
        /// </summary>
        [JsonProperty("calendar")]
        public List<Calendar> Calendar { get; internal set; }
    }
}