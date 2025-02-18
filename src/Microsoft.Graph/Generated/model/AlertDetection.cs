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
    /// The type AlertDetection.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AlertDetection>))]
    public partial class AlertDetection
    {

        /// <summary>
        /// Gets or sets detectionType.
        /// </summary>
        [JsonPropertyName("detectionType")]
        public string DetectionType { get; set; }
    
        /// <summary>
        /// Gets or sets method.
        /// </summary>
        [JsonPropertyName("method")]
        public string Method { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
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
