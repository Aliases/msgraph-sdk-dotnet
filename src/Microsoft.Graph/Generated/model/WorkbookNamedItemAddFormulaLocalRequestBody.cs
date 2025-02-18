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
    /// The type WorkbookNamedItemAddFormulaLocalRequestBody.
    /// </summary>
    public partial class WorkbookNamedItemAddFormulaLocalRequestBody
    {
    
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets Formula.
        /// </summary>
        [JsonPropertyName("formula")]
        public string Formula { get; set; }
    
        /// <summary>
        /// Gets or sets Comment.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    
    }
}
