// -----------------------------------------------------------------------
// <copyright file="ServiceBase.cs" company="Valued Relationships, Inc.">
// Copyright © Valued Relationships, Inc. 2023.
// </copyright>
// -----------------------------------------------------------------------

namespace IFPAServices
{
    using System.Net.Http;
    using Newtonsoft.Json;

    /// <summary>
    /// Abstract class for retrieving data from the IFPA API.
    /// </summary>
    /// <see href="https://www.ifpapinball.com/api/documentation/"/>
    public abstract class ServiceBase
    {
        /// <summary>
        /// Key needed to access API.
        /// </summary>
        private readonly string apiKey;

        /// <summary>
        /// The root of the API's url.
        /// </summary>
        private readonly System.Uri baseUrl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceBase"/> class.
        /// </summary>
        /// <param name="apiKey">Key needed to access API.</param>
        /// <param name="baseUrl">The root of the API's url.</param>
        protected ServiceBase(string apiKey, string baseUrl)
        {
            this.apiKey = apiKey;
            this.baseUrl = new System.Uri(baseUrl);
        }

        /// <summary>
        /// Generates the URL.
        /// </summary>
        /// <param name="subUri">The specific endpoint.</param>
        /// <param name="parameters">Endpoint parameters.</param>
        /// <returns>A string.</returns>
        protected string BuildUri(string subUri, string parameters)
        {
            return $"{this.baseUrl}/{subUri}?api_key={this.apiKey}{parameters}";
        }

        /// <summary>
        /// Generic get request to the API.
        /// </summary>
        /// <typeparam name="TRootObject">Type of the object returned.</typeparam>
        /// <param name="requestUri">URL of the request.</param>
        /// <returns>A deserialized result object.</returns>
        protected TRootObject GenericGet<TRootObject>(string requestUri)
            where TRootObject : new()
        {
            var emptyRootObject = new TRootObject();
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(requestUri).Result;
                if (/*response == null || */!response.IsSuccessStatusCode)
                {
                    return emptyRootObject;
                }

                var json = response.Content.ReadAsStringAsync().Result;
                try
                {
                    var rootObject = JsonConvert.DeserializeObject<TRootObject>(json);
                    ////if (rootObject == null)
                    ////{
                    ////    return emptyRootObject;
                    ////}

                    return rootObject;
                }
                catch
                {
                    return emptyRootObject;
                }
            }
        }
    }
}