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
    /// The interface IWorkbookTableItemAtRequestBuilder.
    /// </summary>
    public partial interface IWorkbookTableItemAtRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookTableItemAtRequest Request(IEnumerable<Option> options = null);
        /// <summary>
        /// Gets the request builder for WorkbookTableAddRequestBuilder.
        /// </summary>
        /// <param name="hasHeaders">A hasHeaders parameter for the OData method call.</param>
        /// <param name="address">A address parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookTableAddRequestBuilder"/>.</returns>
        IWorkbookTableAddRequestBuilder Add(
            bool hasHeaders,
            string address);
        /// <summary>
        /// Gets the request builder for WorkbookTableClearFiltersRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableClearFiltersRequestBuilder"/>.</returns>
        IWorkbookTableClearFiltersRequestBuilder ClearFilters();
        /// <summary>
        /// Gets the request builder for WorkbookTableConvertToRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableConvertToRangeRequestBuilder"/>.</returns>
        IWorkbookTableConvertToRangeRequestBuilder ConvertToRange();
        /// <summary>
        /// Gets the request builder for WorkbookTableCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableCountRequestBuilder"/>.</returns>
        IWorkbookTableCountRequestBuilder Count();
        /// <summary>
        /// Gets the request builder for WorkbookTableDataBodyRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableDataBodyRangeRequestBuilder"/>.</returns>
        IWorkbookTableDataBodyRangeRequestBuilder DataBodyRange();
        /// <summary>
        /// Gets the request builder for WorkbookTableHeaderRowRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableHeaderRowRangeRequestBuilder"/>.</returns>
        IWorkbookTableHeaderRowRangeRequestBuilder HeaderRowRange();
        /// <summary>
        /// Gets the request builder for WorkbookTableItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookTableItemAtRequestBuilder"/>.</returns>
        IWorkbookTableItemAtRequestBuilder ItemAt(
            Int32 index);
        /// <summary>
        /// Gets the request builder for WorkbookTableRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableRangeRequestBuilder"/>.</returns>
        IWorkbookTableRangeRequestBuilder Range();
        /// <summary>
        /// Gets the request builder for WorkbookTableReapplyFiltersRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableReapplyFiltersRequestBuilder"/>.</returns>
        IWorkbookTableReapplyFiltersRequestBuilder ReapplyFilters();
        /// <summary>
        /// Gets the request builder for WorkbookTableTotalRowRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableTotalRowRangeRequestBuilder"/>.</returns>
        IWorkbookTableTotalRowRangeRequestBuilder TotalRowRange();
        /// <summary>
        /// Gets the request builder for Columns.
        /// Represents a collection of all the columns in the table. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnRequestBuilder"/>.</returns>
        IWorkbookTableColumnRequestBuilder Columns  { get; }
        /// <summary>
        /// Gets the request builder for Rows.
        /// Represents a collection of all the rows in the table. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableRowRequestBuilder"/>.</returns>
        IWorkbookTableRowRequestBuilder Rows  { get; }
        /// <summary>
        /// Gets the request builder for Sort.
        /// Represents the sorting for the table. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableSortRequestBuilder"/>.</returns>
        IWorkbookTableSortRequestBuilder Sort  { get; }
        /// <summary>
        /// Gets the request builder for Worksheet.
        /// The worksheet containing the current table. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetRequestBuilder"/>.</returns>
        IWorkbookWorksheetRequestBuilder Worksheet  { get; }
    }
}
