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
    /// The type Win32Lob App.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Win32LobApp>))]
    public partial class Win32LobApp : MobileLobApp
    {
    
        ///<summary>
        /// The Win32LobApp constructor
        ///</summary>
        public Win32LobApp()
        {
            this.ODataType = "microsoft.graph.win32LobApp";
        }

        /// <summary>
        /// Gets or sets applicable architectures.
        /// The Windows architecture(s) for which this app can run on. Possible values are: none, x86, x64, arm, neutral, arm64.
        /// </summary>
        [JsonPropertyName("applicableArchitectures")]
        public WindowsArchitecture? ApplicableArchitectures { get; set; }
    
        /// <summary>
        /// Gets or sets install command line.
        /// The command line to install this app
        /// </summary>
        [JsonPropertyName("installCommandLine")]
        public string InstallCommandLine { get; set; }
    
        /// <summary>
        /// Gets or sets install experience.
        /// The install experience for this app.
        /// </summary>
        [JsonPropertyName("installExperience")]
        public Win32LobAppInstallExperience InstallExperience { get; set; }
    
        /// <summary>
        /// Gets or sets minimum cpu speed in mhz.
        /// The value for the minimum CPU speed which is required to install this app.
        /// </summary>
        [JsonPropertyName("minimumCpuSpeedInMHz")]
        public Int32? MinimumCpuSpeedInMHz { get; set; }
    
        /// <summary>
        /// Gets or sets minimum free disk space in mb.
        /// The value for the minimum free disk space which is required to install this app.
        /// </summary>
        [JsonPropertyName("minimumFreeDiskSpaceInMB")]
        public Int32? MinimumFreeDiskSpaceInMB { get; set; }
    
        /// <summary>
        /// Gets or sets minimum memory in mb.
        /// The value for the minimum physical memory which is required to install this app.
        /// </summary>
        [JsonPropertyName("minimumMemoryInMB")]
        public Int32? MinimumMemoryInMB { get; set; }
    
        /// <summary>
        /// Gets or sets minimum number of processors.
        /// The value for the minimum number of processors which is required to install this app.
        /// </summary>
        [JsonPropertyName("minimumNumberOfProcessors")]
        public Int32? MinimumNumberOfProcessors { get; set; }
    
        /// <summary>
        /// Gets or sets minimum supported windows release.
        /// The value for the minimum supported windows release.
        /// </summary>
        [JsonPropertyName("minimumSupportedWindowsRelease")]
        public string MinimumSupportedWindowsRelease { get; set; }
    
        /// <summary>
        /// Gets or sets msi information.
        /// The MSI details if this Win32 app is an MSI app.
        /// </summary>
        [JsonPropertyName("msiInformation")]
        public Win32LobAppMsiInformation MsiInformation { get; set; }
    
        /// <summary>
        /// Gets or sets return codes.
        /// The return codes for post installation behavior.
        /// </summary>
        [JsonPropertyName("returnCodes")]
        public IEnumerable<Win32LobAppReturnCode> ReturnCodes { get; set; }
    
        /// <summary>
        /// Gets or sets rules.
        /// The detection and requirement rules for this app.
        /// </summary>
        [JsonPropertyName("rules")]
        public IEnumerable<Win32LobAppRule> Rules { get; set; }
    
        /// <summary>
        /// Gets or sets setup file path.
        /// The relative path of the setup file in the encrypted Win32LobApp package.
        /// </summary>
        [JsonPropertyName("setupFilePath")]
        public string SetupFilePath { get; set; }
    
        /// <summary>
        /// Gets or sets uninstall command line.
        /// The command line to uninstall this app
        /// </summary>
        [JsonPropertyName("uninstallCommandLine")]
        public string UninstallCommandLine { get; set; }
    
    }
}

