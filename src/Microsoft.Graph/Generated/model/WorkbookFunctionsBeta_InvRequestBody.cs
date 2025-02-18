// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsBeta_InvRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsBeta_InvRequestBody
    {
    
        /// <summary>
        /// Gets or sets Probability.
        /// </summary>
        [JsonPropertyName("probability")]
        public System.Text.Json.JsonDocument Probability { get; set; }
    
        /// <summary>
        /// Gets or sets Alpha.
        /// </summary>
        [JsonPropertyName("alpha")]
        public System.Text.Json.JsonDocument Alpha { get; set; }
    
        /// <summary>
        /// Gets or sets Beta.
        /// </summary>
        [JsonPropertyName("beta")]
        public System.Text.Json.JsonDocument Beta { get; set; }
    
        /// <summary>
        /// Gets or sets A.
        /// </summary>
        [JsonPropertyName("A")]
        public System.Text.Json.JsonDocument A { get; set; }
    
        /// <summary>
        /// Gets or sets B.
        /// </summary>
        [JsonPropertyName("B")]
        public System.Text.Json.JsonDocument B { get; set; }
    
    }
}
