using System;
using System.Runtime.InteropServices;
using MediaBrowser.Model.Updates;

namespace MediaBrowser.Model.System
{
    /// <summary>
    /// Enum describing the location of the FFmpeg tool.
    /// </summary>
    public enum FFmpegLocation
    {
        /// <summary>No path to FFmpeg found.</summary>
        NotFound,
        /// <summary>Path supplied via command line using switch --ffmpeg.</summary>
        SetByArgument,
        /// <summary>User has supplied path via Transcoding UI page.</summary>
        Custom,
        /// <summary>FFmpeg tool found on system $PATH.</summary>
        System
    };

    /// <summary>
    /// Class SystemInfo
    /// </summary>
    public class SystemInfo : PublicSystemInfo
    {
        public PackageVersionClass SystemUpdateLevel { get; set; }

        /// <summary>
        /// Gets or sets the display name of the operating system.
        /// </summary>
        /// <value>The display name of the operating system.</value>
        public string OperatingSystemDisplayName { get; set; }

        /// <summary>
        /// The product name. This is the AssemblyProduct name.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Get or sets the package name.
        /// </summary>
        /// <value>The value of the '-package' command line argument.</value>
        public string PackageName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has pending restart.
        /// </summary>
        /// <value><c>true</c> if this instance has pending restart; otherwise, <c>false</c>.</value>
        public bool HasPendingRestart { get; set; }

        public bool IsShuttingDown { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports library monitor].
        /// </summary>
        /// <value><c>true</c> if [supports library monitor]; otherwise, <c>false</c>.</value>
        public bool SupportsLibraryMonitor { get; set; }

        /// <summary>
        /// Gets or sets the web socket port number.
        /// </summary>
        /// <value>The web socket port number.</value>
        public int WebSocketPortNumber { get; set; }

        /// <summary>
        /// Gets or sets the completed installations.
        /// </summary>
        /// <value>The completed installations.</value>
        public InstallationInfo[] CompletedInstallations { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance can self restart.
        /// </summary>
        /// <value><c>true</c> if this instance can self restart; otherwise, <c>false</c>.</value>
        public bool CanSelfRestart { get; set; }

        public bool CanLaunchWebBrowser { get; set; }

        /// <summary>
        /// Gets or sets the program data path.
        /// </summary>
        /// <value>The program data path.</value>
        public string ProgramDataPath { get; set; }

        /// <summary>
        /// Gets or sets the items by name path.
        /// </summary>
        /// <value>The items by name path.</value>
        public string ItemsByNamePath { get; set; }

        /// <summary>
        /// Gets or sets the cache path.
        /// </summary>
        /// <value>The cache path.</value>
        public string CachePath { get; set; }

        /// <summary>
        /// Gets or sets the log path.
        /// </summary>
        /// <value>The log path.</value>
        public string LogPath { get; set; }

        /// <summary>
        /// Gets or sets the internal metadata path.
        /// </summary>
        /// <value>The internal metadata path.</value>
        public string InternalMetadataPath { get; set; }

        /// <summary>
        /// Gets or sets the transcoding temporary path.
        /// </summary>
        /// <value>The transcoding temporary path.</value>
        public string TranscodingTempPath { get; set; }

        /// <summary>
        /// Gets or sets the HTTP server port number.
        /// </summary>
        /// <value>The HTTP server port number.</value>
        public int HttpServerPortNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable HTTPS].
        /// </summary>
        /// <value><c>true</c> if [enable HTTPS]; otherwise, <c>false</c>.</value>
        public bool SupportsHttps { get; set; }

        /// <summary>
        /// Gets or sets the HTTPS server port number.
        /// </summary>
        /// <value>The HTTPS server port number.</value>
        public int HttpsPortNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has update available.
        /// </summary>
        /// <value><c>true</c> if this instance has update available; otherwise, <c>false</c>.</value>
        public bool HasUpdateAvailable { get; set; }

        public FFmpegLocation EncoderLocation { get; set; }

        public Architecture SystemArchitecture { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfo" /> class.
        /// </summary>
        public SystemInfo()
        {
            CompletedInstallations = Array.Empty<InstallationInfo>();
        }
    }
}
