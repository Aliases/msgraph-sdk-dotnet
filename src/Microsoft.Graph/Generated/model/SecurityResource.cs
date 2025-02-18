// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SecurityResource.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SecurityResource>))]
    public partial class SecurityResource
    {

        /// <summary>
        /// Gets or sets resource.
        /// Name of the resource that is related to current alert. Required.
        /// </summary>
        [JsonPropertyName("resource")]
        public string Resource { get; set; }
    
        /// <summary>
        /// Gets or sets resourceType.
        /// Represents type of security resources related to an alert. Possible values are: attacked, related.
        /// </summary>
        [JsonPropertyName("resourceType")]
        public SecurityResourceType? ResourceType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
