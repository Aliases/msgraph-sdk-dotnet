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
    /// The type TeleconferenceDeviceMediaQuality.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeleconferenceDeviceMediaQuality>))]
    public abstract partial class TeleconferenceDeviceMediaQuality
    {

        /// <summary>
        /// Gets or sets averageInboundJitter.
        /// The average inbound stream network jitter.
        /// </summary>
        [JsonPropertyName("averageInboundJitter")]
        public Duration AverageInboundJitter { get; set; }
    
        /// <summary>
        /// Gets or sets averageInboundPacketLossRateInPercentage.
        /// The average inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
        /// </summary>
        [JsonPropertyName("averageInboundPacketLossRateInPercentage")]
        public double? AverageInboundPacketLossRateInPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets averageInboundRoundTripDelay.
        /// The average inbound stream network round trip delay.
        /// </summary>
        [JsonPropertyName("averageInboundRoundTripDelay")]
        public Duration AverageInboundRoundTripDelay { get; set; }
    
        /// <summary>
        /// Gets or sets averageOutboundJitter.
        /// The average outbound stream network jitter.
        /// </summary>
        [JsonPropertyName("averageOutboundJitter")]
        public Duration AverageOutboundJitter { get; set; }
    
        /// <summary>
        /// Gets or sets averageOutboundPacketLossRateInPercentage.
        /// The average outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
        /// </summary>
        [JsonPropertyName("averageOutboundPacketLossRateInPercentage")]
        public double? AverageOutboundPacketLossRateInPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets averageOutboundRoundTripDelay.
        /// The average outbound stream network round trip delay.
        /// </summary>
        [JsonPropertyName("averageOutboundRoundTripDelay")]
        public Duration AverageOutboundRoundTripDelay { get; set; }
    
        /// <summary>
        /// Gets or sets channelIndex.
        /// The channel index of media. Indexing begins with 1.  If a media session contains 3 video modalities, channel indexes will be 1, 2, and 3.
        /// </summary>
        [JsonPropertyName("channelIndex")]
        public Int32? ChannelIndex { get; set; }
    
        /// <summary>
        /// Gets or sets inboundPackets.
        /// The total number of the inbound packets.
        /// </summary>
        [JsonPropertyName("inboundPackets")]
        public Int64? InboundPackets { get; set; }
    
        /// <summary>
        /// Gets or sets localIPAddress.
        /// the local IP address for the media session.
        /// </summary>
        [JsonPropertyName("localIPAddress")]
        public string LocalIPAddress { get; set; }
    
        /// <summary>
        /// Gets or sets localPort.
        /// The local media port.
        /// </summary>
        [JsonPropertyName("localPort")]
        public Int32? LocalPort { get; set; }
    
        /// <summary>
        /// Gets or sets maximumInboundJitter.
        /// The maximum inbound stream network jitter.
        /// </summary>
        [JsonPropertyName("maximumInboundJitter")]
        public Duration MaximumInboundJitter { get; set; }
    
        /// <summary>
        /// Gets or sets maximumInboundPacketLossRateInPercentage.
        /// The maximum inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
        /// </summary>
        [JsonPropertyName("maximumInboundPacketLossRateInPercentage")]
        public double? MaximumInboundPacketLossRateInPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets maximumInboundRoundTripDelay.
        /// The maximum inbound stream network round trip delay.
        /// </summary>
        [JsonPropertyName("maximumInboundRoundTripDelay")]
        public Duration MaximumInboundRoundTripDelay { get; set; }
    
        /// <summary>
        /// Gets or sets maximumOutboundJitter.
        /// The maximum outbound stream network jitter.
        /// </summary>
        [JsonPropertyName("maximumOutboundJitter")]
        public Duration MaximumOutboundJitter { get; set; }
    
        /// <summary>
        /// Gets or sets maximumOutboundPacketLossRateInPercentage.
        /// The maximum outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
        /// </summary>
        [JsonPropertyName("maximumOutboundPacketLossRateInPercentage")]
        public double? MaximumOutboundPacketLossRateInPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets maximumOutboundRoundTripDelay.
        /// The maximum outbound stream network round trip delay.
        /// </summary>
        [JsonPropertyName("maximumOutboundRoundTripDelay")]
        public Duration MaximumOutboundRoundTripDelay { get; set; }
    
        /// <summary>
        /// Gets or sets mediaDuration.
        /// The total modality duration. If the media enabled and disabled multiple times, MediaDuration will the summation of all of the durations.
        /// </summary>
        [JsonPropertyName("mediaDuration")]
        public Duration MediaDuration { get; set; }
    
        /// <summary>
        /// Gets or sets networkLinkSpeedInBytes.
        /// The network link speed in bytes
        /// </summary>
        [JsonPropertyName("networkLinkSpeedInBytes")]
        public Int64? NetworkLinkSpeedInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets outboundPackets.
        /// The total number of the outbound packets.
        /// </summary>
        [JsonPropertyName("outboundPackets")]
        public Int64? OutboundPackets { get; set; }
    
        /// <summary>
        /// Gets or sets remoteIPAddress.
        /// The remote IP address for the media session.
        /// </summary>
        [JsonPropertyName("remoteIPAddress")]
        public string RemoteIPAddress { get; set; }
    
        /// <summary>
        /// Gets or sets remotePort.
        /// The remote media port.
        /// </summary>
        [JsonPropertyName("remotePort")]
        public Int32? RemotePort { get; set; }
    
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
