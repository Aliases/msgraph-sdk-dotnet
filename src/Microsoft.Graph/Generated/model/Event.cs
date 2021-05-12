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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Event.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Event : OutlookItem
    {
    
		///<summary>
		/// The Event constructor
		///</summary>
        public Event()
        {
            this.ODataType = "microsoft.graph.event";
        }
	
        /// <summary>
        /// Gets or sets allow new time proposals.
        /// True if the meeting organizer allows invitees to propose a new time when responding, false otherwise. Optional. Default is true.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowNewTimeProposals", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowNewTimeProposals { get; set; }
    
        /// <summary>
        /// Gets or sets attendees.
        /// The collection of attendees for the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attendees", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Attendee> Attendees { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// The body of the message associated with the event. It can be in HTML or text format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "body", Required = Newtonsoft.Json.Required.Default)]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets body preview.
        /// The preview of the message associated with the event. It is in text format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bodyPreview", Required = Newtonsoft.Json.Required.Default)]
        public string BodyPreview { get; set; }
    
        /// <summary>
        /// Gets or sets end.
        /// The date, time, and time zone that the event ends. By default, the end time is in UTC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone End { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// Set to true if the event has attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets hide attendees.
        /// When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hideAttendees", Required = Newtonsoft.Json.Required.Default)]
        public bool? HideAttendees { get; set; }
    
        /// <summary>
        /// Gets or sets i cal uid.
        /// A unique identifier for an event across calendars. This ID is different for each occurrence in a recurring series. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iCalUId", Required = Newtonsoft.Json.Required.Default)]
        public string ICalUId { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// The importance of the event. The possible values are: low, normal, high.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importance", Required = Newtonsoft.Json.Required.Default)]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets is all day.
        /// Set to true if the event lasts all day.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAllDay", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAllDay { get; set; }
    
        /// <summary>
        /// Gets or sets is cancelled.
        /// Set to true if the event has been canceled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isCancelled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsCancelled { get; set; }
    
        /// <summary>
        /// Gets or sets is draft.
        /// Set to true if the user has updated the meeting in Outlook but has not sent the updates to attendees. Set to false if all changes have been sent, or if the event is an appointment without any attendees.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDraft", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDraft { get; set; }
    
        /// <summary>
        /// Gets or sets is online meeting.
        /// True if this event has online meeting information, false otherwise. Default is false. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isOnlineMeeting", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsOnlineMeeting { get; set; }
    
        /// <summary>
        /// Gets or sets is organizer.
        /// Set to true if the calendar owner (specified by the owner property of the calendar) is the organizer of the event (specified by the organizer property of the event). This also applies if a delegate organized the event on behalf of the owner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isOrganizer", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsOrganizer { get; set; }
    
        /// <summary>
        /// Gets or sets is reminder on.
        /// Set to true if an alert is set to remind the user of the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isReminderOn", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsReminderOn { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// The location of the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location", Required = Newtonsoft.Json.Required.Default)]
        public Location Location { get; set; }
    
        /// <summary>
        /// Gets or sets locations.
        /// The locations where the event is held or attended from. The location and locations properties always correspond with each other. If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Location> Locations { get; set; }
    
        /// <summary>
        /// Gets or sets online meeting.
        /// Details for an attendee to join the meeting online. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlineMeeting", Required = Newtonsoft.Json.Required.Default)]
        public OnlineMeetingInfo OnlineMeeting { get; set; }
    
        /// <summary>
        /// Gets or sets online meeting provider.
        /// Represents the online meeting service provider. The possible values are teamsForBusiness, skypeForBusiness, and skypeForConsumer. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlineMeetingProvider", Required = Newtonsoft.Json.Required.Default)]
        public OnlineMeetingProviderType? OnlineMeetingProvider { get; set; }
    
        /// <summary>
        /// Gets or sets online meeting url.
        /// A URL for an online meeting. The property is set only when an organizer specifies an event as an online meeting such as a Skype meeting. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlineMeetingUrl", Required = Newtonsoft.Json.Required.Default)]
        public string OnlineMeetingUrl { get; set; }
    
        /// <summary>
        /// Gets or sets organizer.
        /// The organizer of the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizer", Required = Newtonsoft.Json.Required.Default)]
        public Recipient Organizer { get; set; }
    
        /// <summary>
        /// Gets or sets original end time zone.
        /// The end time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalEndTimeZone", Required = Newtonsoft.Json.Required.Default)]
        public string OriginalEndTimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets original start.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalStart", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OriginalStart { get; set; }
    
        /// <summary>
        /// Gets or sets original start time zone.
        /// The start time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalStartTimeZone", Required = Newtonsoft.Json.Required.Default)]
        public string OriginalStartTimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// The recurrence pattern for the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recurrence", Required = Newtonsoft.Json.Required.Default)]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets reminder minutes before start.
        /// The number of minutes before the event start time that the reminder alert occurs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reminderMinutesBeforeStart", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ReminderMinutesBeforeStart { get; set; }
    
        /// <summary>
        /// Gets or sets response requested.
        /// Default is true, which represents the organizer would like an invitee to send a response to the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responseRequested", Required = Newtonsoft.Json.Required.Default)]
        public bool? ResponseRequested { get; set; }
    
        /// <summary>
        /// Gets or sets response status.
        /// Indicates the type of response sent in response to an event message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responseStatus", Required = Newtonsoft.Json.Required.Default)]
        public ResponseStatus ResponseStatus { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivity.
        /// The possible values are: normal, personal, private, confidential.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sensitivity", Required = Newtonsoft.Json.Required.Default)]
        public Sensitivity? Sensitivity { get; set; }
    
        /// <summary>
        /// Gets or sets series master id.
        /// The ID for the recurring series master item, if this event is part of a recurring series.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "seriesMasterId", Required = Newtonsoft.Json.Required.Default)]
        public string SeriesMasterId { get; set; }
    
        /// <summary>
        /// Gets or sets show as.
        /// The status to show. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showAs", Required = Newtonsoft.Json.Required.Default)]
        public FreeBusyStatus? ShowAs { get; set; }
    
        /// <summary>
        /// Gets or sets start.
        /// The date, time, and time zone that the event starts. By default, the start time is in UTC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone Start { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The text of the event's subject line.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets transaction id.
        /// A custom identifier specified by a client app for the server to avoid redundant POST operations in case of client retries to create the same event. This is useful when low network connectivity causes the client to time out before receiving a response from the server for the client's prior create-event request. After you set transactionId when creating an event, you cannot change transactionId in a subsequent update. This property is only returned in a response payload if an app has set it. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transactionId", Required = Newtonsoft.Json.Required.Default)]
        public string TransactionId { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The event type. The possible values are: singleInstance, occurrence, exception, seriesMaster. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public EventType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets web link.
        /// The URL to open the event in Outlook on the web.Outlook on the web opens the event in the browser if you are signed in to your mailbox. Otherwise, Outlook on the web prompts you to sign in.This URL cannot be accessed from within an iFrame.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webLink", Required = Newtonsoft.Json.Required.Default)]
        public string WebLink { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attachments", Required = Newtonsoft.Json.Required.Default)]
        public IEventAttachmentsCollectionPage Attachments { get; set; }
    
        /// <summary>
        /// Gets or sets calendar.
        /// The calendar that contains the event. Navigation property. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendar", Required = Newtonsoft.Json.Required.Default)]
        public Calendar Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the event. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IEventExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets instances.
        /// The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instances", Required = Newtonsoft.Json.Required.Default)]
        public IEventInstancesCollectionPage Instances { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the event. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IEventMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the event. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IEventSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
    }
}

