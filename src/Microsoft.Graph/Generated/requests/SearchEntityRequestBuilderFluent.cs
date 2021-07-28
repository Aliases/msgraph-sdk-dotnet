﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SearchEntityRequestBuilder.
    /// </summary>
    public partial class SearchEntityRequestBuilderFluent : EntityRequestBuilder, ISearchEntityRequestBuilder, BaseActionMethodRequestBuilder<ISearchEntityQueryRequest>
    {

        public IList<QueryOption> QueryOptions { get; set; }

        /// <summary>
        /// Constructs a new SearchEntityRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SearchEntityRequestBuilderFluent(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISearchEntityRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISearchEntityRequest Request(IEnumerable<Option> options)
        {
            return new SearchEntityRequest(this.RequestUrl, this.Client, options);
        }

        public SearchEntityRequestBuilderFluent From(
            int from)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$from", from.ToString()));
            return this;
        }

        public SearchEntityRequestBuilderFluent WithSize(
             int size)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$size", size.ToString()));
            return this;
        }

        public SearchEntityRequestBuilderFluent WithODataType(
            string oDataType)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$@odata.type", oDataType));
            return this;
        }

        /// <summary>
        /// Gets the request builder for SearchEntityQuery.
        /// </summary>
        /// <returns>The <see cref="ISearchEntityQueryRequestBuilder"/>.</returns>
        ///         public SearchRequestObject();
        ///         IEnumerable<string> ContentSources 
        ///         bool? EnableTopResults 
        ///         IEnumerable<EntityType> EntityTypes
        ///          IEnumerable<string> Fields 
        ///          IDictionary<string, object> AdditionalData
        ///          SearchQuery Query
        ///          int? From 
        ///          int? Size
        ///          string ODataType 
        public SearchEntityRequestBuilderFluent Query(
            IEnumerable<SearchRequestObject> requests)
        {
            // What should the fluent syntax for request body look like?

            //options -
            //customer.newOrder()
            //    .with(6, "TAL")
            //    .with(5, "HPK").skippable()
            //    .with(3, "LGV")
            //    .priorityRush();

            //return await Client.Me.People
            //     .Request()
            //     .Top(topN)
            //     .GetAsync();

            //  var requests = new List<SearchRequestObject>(){};
            //var page = await Client.Search
            //    .Query(requests)
            //    .Request()
            //    .PostAsync();

            //this.Query

            //https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/combined-fields-usage.html
            //{
            //    "combined_fields": {
            //        "_name": "combined_fields",
            //        "boost": 1.1,
            //        "query": "hello world",
            //        "minimum_should_match": "2",
            //        "operator": "or",
            //        "fields": [
            //          "description",
            //          "myOtherField"
            //                      ],
            //        "zero_terms_query": "all",
            //        "auto_generate_synonyms_phrase_query": false
            //    }
            //}

            //q
            //    .CombinedFields(c => c
            //        .Fields(f => f.Field(p => p.Description).Field("myOtherField"))
            //        .Query("hello world")
            //        .Boost(1.1)
            //        .Operator(Operator.Or)
            //        .MinimumShouldMatch("2")
            //        .ZeroTermsQuery(ZeroTermsQuery.All)
            //        .Name("combined_fields")
            //        .AutoGenerateSynonymsPhraseQuery(false)
            //    )

            return new SearchEntityRequestBuilderFluent(
                this.AppendSegmentToRequestUrl("microsoft.graph.query"),
                this.Client,
                requests);

            //return this;
        }

        /// <summary>
        /// Constructs a new <see cref="SearchEntityQueryRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="requests">A requests parameter for the OData method call.</param>
        public SearchEntityRequestBuilderFluent(
            string requestUrl,
            IBaseClient client,
            IEnumerable<SearchRequestObject> requests)
            : base(requestUrl, client)
        {
            this.SetParameter("requests", requests, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ISearchEntityQueryRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new SearchEntityQueryRequest(functionUrl, this.Client, options);

            if (this.HasParameter("requests"))
            {
                request.RequestBody.Requests = this.GetParameter<IEnumerable<SearchRequestObject>>("requests");
            }

            return request;
        }

    }
}
