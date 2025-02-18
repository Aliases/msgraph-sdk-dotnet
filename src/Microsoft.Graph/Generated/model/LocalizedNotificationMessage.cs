// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Localized Notification Message.
    /// </summary>
    public partial class LocalizedNotificationMessage : Entity
    {
    
        /// <summary>
        /// Gets or sets is default.
        /// Flag to indicate whether or not this is the default locale for language fallback. This flag can only be set. To unset, set this property to true on another Localized Notification Message.
        /// </summary>
        [JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets locale.
        /// The Locale for which this message is destined.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }
    
        /// <summary>
        /// Gets or sets message template.
        /// The Message Template content.
        /// </summary>
        [JsonPropertyName("messageTemplate")]
        public string MessageTemplate { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The Message Template Subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
    }
}

