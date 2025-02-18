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
    /// The interface IMdmWindowsInformationProtectionPolicyRequest.
    /// </summary>
    public partial interface IMdmWindowsInformationProtectionPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MdmWindowsInformationProtectionPolicy using POST.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToCreate">The MdmWindowsInformationProtectionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MdmWindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> CreateAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MdmWindowsInformationProtectionPolicy using POST and returns a <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToCreate">The MdmWindowsInformationProtectionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MdmWindowsInformationProtectionPolicy>> CreateResponseAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MdmWindowsInformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MdmWindowsInformationProtectionPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MdmWindowsInformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MdmWindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MdmWindowsInformationProtectionPolicy and returns a <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MdmWindowsInformationProtectionPolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicy using PATCH.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToUpdate">The MdmWindowsInformationProtectionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MdmWindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> UpdateAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicy using PATCH and returns a <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToUpdate">The MdmWindowsInformationProtectionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MdmWindowsInformationProtectionPolicy>> UpdateResponseAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicy using PUT.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToUpdate">The MdmWindowsInformationProtectionPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> PutAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicy using PUT and returns a <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToUpdate">The MdmWindowsInformationProtectionPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MdmWindowsInformationProtectionPolicy>> PutResponseAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMdmWindowsInformationProtectionPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMdmWindowsInformationProtectionPolicyRequest Expand(Expression<Func<MdmWindowsInformationProtectionPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMdmWindowsInformationProtectionPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMdmWindowsInformationProtectionPolicyRequest Select(Expression<Func<MdmWindowsInformationProtectionPolicy, object>> selectExpression);

    }
}
