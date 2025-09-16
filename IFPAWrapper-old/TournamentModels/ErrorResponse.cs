// -----------------------------------------------------------------------
// <copyright file="ErrorResponse.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAWrapper.TournamentModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// Reports an API error.
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// Gets a description of the error.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; internal set; }
    }
}
