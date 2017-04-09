namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Capture page screenshot.
    /// </summary>
    public sealed class CaptureScreenshotCommand : ICommand<CaptureScreenshotCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.captureScreenshot";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class CaptureScreenshotCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Base64-encoded image data (PNG).
        ///</summary>
        
        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
    
    }
}