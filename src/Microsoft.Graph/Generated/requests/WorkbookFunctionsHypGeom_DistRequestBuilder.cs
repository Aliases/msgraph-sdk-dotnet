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
    /// The type WorkbookFunctionsHypGeom_DistRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsHypGeom_DistRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsHypGeom_DistRequest>, IWorkbookFunctionsHypGeom_DistRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsHypGeom_DistRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="sampleS">A sampleS parameter for the OData method call.</param>
        /// <param name="numberSample">A numberSample parameter for the OData method call.</param>
        /// <param name="populationS">A populationS parameter for the OData method call.</param>
        /// <param name="numberPop">A numberPop parameter for the OData method call.</param>
        /// <param name="cumulative">A cumulative parameter for the OData method call.</param>
        public WorkbookFunctionsHypGeom_DistRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument sampleS,
            System.Text.Json.JsonDocument numberSample,
            System.Text.Json.JsonDocument populationS,
            System.Text.Json.JsonDocument numberPop,
            System.Text.Json.JsonDocument cumulative)
            : base(requestUrl, client)
        {
            this.SetParameter("sampleS", sampleS, true);
            this.SetParameter("numberSample", numberSample, true);
            this.SetParameter("populationS", populationS, true);
            this.SetParameter("numberPop", numberPop, true);
            this.SetParameter("cumulative", cumulative, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsHypGeom_DistRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsHypGeom_DistRequest(functionUrl, this.Client, options);

            if (this.HasParameter("sampleS"))
            {
                request.RequestBody.SampleS = this.GetParameter<System.Text.Json.JsonDocument>("sampleS");
            }

            if (this.HasParameter("numberSample"))
            {
                request.RequestBody.NumberSample = this.GetParameter<System.Text.Json.JsonDocument>("numberSample");
            }

            if (this.HasParameter("populationS"))
            {
                request.RequestBody.PopulationS = this.GetParameter<System.Text.Json.JsonDocument>("populationS");
            }

            if (this.HasParameter("numberPop"))
            {
                request.RequestBody.NumberPop = this.GetParameter<System.Text.Json.JsonDocument>("numberPop");
            }

            if (this.HasParameter("cumulative"))
            {
                request.RequestBody.Cumulative = this.GetParameter<System.Text.Json.JsonDocument>("cumulative");
            }

            return request;
        }
    }
}
