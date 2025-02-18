// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type External.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<External>))]
    public partial class External
    {
    
        /// <summary>
        /// Gets or sets connections.
        /// </summary>
        [JsonPropertyName("connections")]
        public IExternalConnectionsCollectionPage Connections { get; set; }

        /// <summary>
        /// Gets or sets connectionsNextLink.
        /// </summary>
        [JsonPropertyName("connections@odata.nextLink")]
        public string ConnectionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

