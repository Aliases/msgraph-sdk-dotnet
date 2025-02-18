// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum ConditionalAccessDevicePlatform.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ConditionalAccessDevicePlatform
    {
    
        /// <summary>
        /// Android
        /// </summary>
        Android = 0,
	
        /// <summary>
        /// IOS
        /// </summary>
        IOS = 1,
	
        /// <summary>
        /// Windows
        /// </summary>
        Windows = 2,
	
        /// <summary>
        /// Windows Phone
        /// </summary>
        WindowsPhone = 3,
	
        /// <summary>
        /// Mac OS
        /// </summary>
        MacOS = 4,
	
        /// <summary>
        /// All
        /// </summary>
        All = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 6,
	
    }
}
