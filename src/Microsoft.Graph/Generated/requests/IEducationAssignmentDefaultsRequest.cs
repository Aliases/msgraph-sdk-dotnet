// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IEducationAssignmentDefaultsRequest.
    /// </summary>
    public partial interface IEducationAssignmentDefaultsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationAssignmentDefaults using POST.
        /// </summary>
        /// <param name="educationAssignmentDefaultsToCreate">The EducationAssignmentDefaults to create.</param>
        /// <returns>The created EducationAssignmentDefaults.</returns>
        System.Threading.Tasks.Task<EducationAssignmentDefaults> CreateAsync(EducationAssignmentDefaults educationAssignmentDefaultsToCreate);        /// <summary>
        /// Creates the specified EducationAssignmentDefaults using POST.
        /// </summary>
        /// <param name="educationAssignmentDefaultsToCreate">The EducationAssignmentDefaults to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationAssignmentDefaults.</returns>
        System.Threading.Tasks.Task<EducationAssignmentDefaults> CreateAsync(EducationAssignmentDefaults educationAssignmentDefaultsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EducationAssignmentDefaults.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EducationAssignmentDefaults.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EducationAssignmentDefaults.
        /// </summary>
        /// <returns>The EducationAssignmentDefaults.</returns>
        System.Threading.Tasks.Task<EducationAssignmentDefaults> GetAsync();

        /// <summary>
        /// Gets the specified EducationAssignmentDefaults.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationAssignmentDefaults.</returns>
        System.Threading.Tasks.Task<EducationAssignmentDefaults> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EducationAssignmentDefaults using PATCH.
        /// </summary>
        /// <param name="educationAssignmentDefaultsToUpdate">The EducationAssignmentDefaults to update.</param>
        /// <returns>The updated EducationAssignmentDefaults.</returns>
        System.Threading.Tasks.Task<EducationAssignmentDefaults> UpdateAsync(EducationAssignmentDefaults educationAssignmentDefaultsToUpdate);

        /// <summary>
        /// Updates the specified EducationAssignmentDefaults using PATCH.
        /// </summary>
        /// <param name="educationAssignmentDefaultsToUpdate">The EducationAssignmentDefaults to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationAssignmentDefaults.</returns>
        System.Threading.Tasks.Task<EducationAssignmentDefaults> UpdateAsync(EducationAssignmentDefaults educationAssignmentDefaultsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentDefaultsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentDefaultsRequest Expand(Expression<Func<EducationAssignmentDefaults, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentDefaultsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentDefaultsRequest Select(Expression<Func<EducationAssignmentDefaults, object>> selectExpression);

    }
}
