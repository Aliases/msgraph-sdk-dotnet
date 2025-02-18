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
    /// The type ChoiceColumn.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ChoiceColumn>))]
    public partial class ChoiceColumn
    {

        /// <summary>
        /// Gets or sets allowTextEntry.
        /// If true, allows custom values that aren't in the configured choices.
        /// </summary>
        [JsonPropertyName("allowTextEntry")]
        public bool? AllowTextEntry { get; set; }
    
        /// <summary>
        /// Gets or sets choices.
        /// The list of values available for this column.
        /// </summary>
        [JsonPropertyName("choices")]
        public IEnumerable<string> Choices { get; set; }
    
        /// <summary>
        /// Gets or sets displayAs.
        /// How the choices are to be presented in the UX. Must be one of checkBoxes, dropDownMenu, or radioButtons
        /// </summary>
        [JsonPropertyName("displayAs")]
        public string DisplayAs { get; set; }
    
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
