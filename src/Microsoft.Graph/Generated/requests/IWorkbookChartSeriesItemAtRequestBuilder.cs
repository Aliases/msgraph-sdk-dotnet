// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookChartSeriesItemAtRequestBuilder.
    /// </summary>
    public partial interface IWorkbookChartSeriesItemAtRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookChartSeriesItemAtRequest Request(IEnumerable<Option> options = null);
        /// <summary>
        /// Gets the request builder for WorkbookChartSeriesCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesCountRequestBuilder"/>.</returns>
        IWorkbookChartSeriesCountRequestBuilder Count();
        /// <summary>
        /// Gets the request builder for WorkbookChartSeriesItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookChartSeriesItemAtRequestBuilder"/>.</returns>
        IWorkbookChartSeriesItemAtRequestBuilder ItemAt(
            Int32 index);
        /// <summary>
        /// Gets the request builder for Format.
        /// Represents the formatting of a chart series, which includes fill and line formatting. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesFormatRequestBuilder"/>.</returns>
        IWorkbookChartSeriesFormatRequestBuilder Format  { get; }
        /// <summary>
        /// Gets the request builder for Points.
        /// Represents a collection of all points in the series. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointRequestBuilder"/>.</returns>
        IWorkbookChartPointRequestBuilder Points  { get; }
    }
}
