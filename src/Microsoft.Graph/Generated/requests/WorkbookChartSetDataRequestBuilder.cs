// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartSetDataRequestBuilder.
    /// </summary>
    public partial class WorkbookChartSetDataRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookChartSetDataRequest>, IWorkbookChartSetDataRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookChartSetDataRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="seriesBy">A seriesBy parameter for the OData method call.</param>
        /// <param name="sourceData">A sourceData parameter for the OData method call.</param>
        public WorkbookChartSetDataRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string seriesBy,
            System.Text.Json.JsonDocument sourceData)
            : base(requestUrl, client)
        {
            this.SetParameter("seriesBy", seriesBy, false);
            this.SetParameter("sourceData", sourceData, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookChartSetDataRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookChartSetDataRequest(functionUrl, this.Client, options);

            if (this.HasParameter("seriesBy"))
            {
                request.RequestBody.SeriesBy = this.GetParameter<string>("seriesBy");
            }

            if (this.HasParameter("sourceData"))
            {
                request.RequestBody.SourceData = this.GetParameter<System.Text.Json.JsonDocument>("sourceData");
            }

            return request;
        }
    }
}
