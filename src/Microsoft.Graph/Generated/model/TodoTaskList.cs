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
    /// The type Todo Task List.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TodoTaskList>))]
    public partial class TodoTaskList : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the task list.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is owner.
        /// True if the user is owner of the given task list.
        /// </summary>
        [JsonPropertyName("isOwner")]
        public bool? IsOwner { get; set; }
    
        /// <summary>
        /// Gets or sets is shared.
        /// True if the task list is shared with other users
        /// </summary>
        [JsonPropertyName("isShared")]
        public bool? IsShared { get; set; }
    
        /// <summary>
        /// Gets or sets wellknown list name.
        /// Property indicating the list name if the given list is a well-known list. Possible values are: none, defaultList, flaggedEmails, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("wellknownListName")]
        public WellknownListName? WellknownListName { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the task list. Nullable.
        /// </summary>
        [JsonPropertyName("extensions")]
        public ITodoTaskListExtensionsCollectionPage Extensions { get; set; }

        /// <summary>
        /// Gets or sets extensionsNextLink.
        /// </summary>
        [JsonPropertyName("extensions@odata.nextLink")]
        public string ExtensionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// The tasks in this task list. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("tasks")]
        public ITodoTaskListTasksCollectionPage Tasks { get; set; }

        /// <summary>
        /// Gets or sets tasksNextLink.
        /// </summary>
        [JsonPropertyName("tasks@odata.nextLink")]
        public string TasksNextLink { get; set; }
    
    }
}

