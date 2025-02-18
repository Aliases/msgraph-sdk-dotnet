// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type BaseItemVersionRequest.
    /// </summary>
    public partial class BaseItemVersionRequest : BaseRequest, IBaseItemVersionRequest
    {
        /// <summary>
        /// Constructs a new BaseItemVersionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public BaseItemVersionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified BaseItemVersion using POST.
        /// </summary>
        /// <param name="baseItemVersionToCreate">The BaseItemVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BaseItemVersion.</returns>
        public async System.Threading.Tasks.Task<BaseItemVersion> CreateAsync(BaseItemVersion baseItemVersionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<BaseItemVersion>(baseItemVersionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified BaseItemVersion using POST and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <param name="baseItemVersionToCreate">The BaseItemVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BaseItemVersion}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> CreateResponseAsync(BaseItemVersion baseItemVersionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<BaseItemVersion>(baseItemVersionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified BaseItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<BaseItemVersion>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified BaseItemVersion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified BaseItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BaseItemVersion.</returns>
        public async System.Threading.Tasks.Task<BaseItemVersion> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<BaseItemVersion>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified BaseItemVersion and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BaseItemVersion}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<BaseItemVersion>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified BaseItemVersion using PATCH.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BaseItemVersion.</returns>
        public async System.Threading.Tasks.Task<BaseItemVersion> UpdateAsync(BaseItemVersion baseItemVersionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<BaseItemVersion>(baseItemVersionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified BaseItemVersion using PATCH and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BaseItemVersion}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> UpdateResponseAsync(BaseItemVersion baseItemVersionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<BaseItemVersion>(baseItemVersionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified BaseItemVersion using PUT.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<BaseItemVersion> PutAsync(BaseItemVersion baseItemVersionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<BaseItemVersion>(baseItemVersionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified BaseItemVersion using PUT and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{BaseItemVersion}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> PutResponseAsync(BaseItemVersion baseItemVersionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<BaseItemVersion>(baseItemVersionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBaseItemVersionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBaseItemVersionRequest Expand(Expression<Func<BaseItemVersion, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IBaseItemVersionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IBaseItemVersionRequest Select(Expression<Func<BaseItemVersion, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="baseItemVersionToInitialize">The <see cref="BaseItemVersion"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(BaseItemVersion baseItemVersionToInitialize)
        {

        }
    }
}
