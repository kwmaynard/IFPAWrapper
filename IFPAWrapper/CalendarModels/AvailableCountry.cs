// -----------------------------------------------------------------------
// <copyright file="AvailableCountry.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAWrapper.CalendarModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// Contains country name.
    /// </summary>
    public class AvailableCountry
    {
        /// <summary>
        /// Gets the country name.
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; internal set; }
    }
}