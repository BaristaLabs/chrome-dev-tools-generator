namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media query results).
    /// </summary>
    public sealed class SetDeviceMetricsOverrideCommand : ICommand<SetDeviceMetricsOverrideCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setDeviceMetricsOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Overriding width value in pixels (minimum 0, maximum 10000000). 0 disables the override.
        /// </summary>
        
        [JsonProperty("width")]
        public long Width
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Overriding height value in pixels (minimum 0, maximum 10000000). 0 disables the override.
        /// </summary>
        
        [JsonProperty("height")]
        public long Height
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Overriding device scale factor value. 0 disables the override.
        /// </summary>
        
        [JsonProperty("deviceScaleFactor")]
        public double DeviceScaleFactor
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text autosizing and more.
        /// </summary>
        
        [JsonProperty("mobile")]
        public bool Mobile
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether a view that exceeds the available browser window area should be scaled down to fit.
        /// </summary>
        
        [JsonProperty("fitWindow")]
        public bool FitWindow
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Scale to apply to resulting view image. Ignored in |fitWindow| mode.
        /// </summary>
        
        [JsonProperty("scale")]
        public double Scale
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// X offset to shift resulting view image by. Ignored in |fitWindow| mode.
        /// </summary>
        
        [JsonProperty("offsetX")]
        public double OffsetX
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Y offset to shift resulting view image by. Ignored in |fitWindow| mode.
        /// </summary>
        
        [JsonProperty("offsetY")]
        public double OffsetY
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Overriding screen width value in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
        /// </summary>
        
        [JsonProperty("screenWidth")]
        public long ScreenWidth
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Overriding screen height value in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
        /// </summary>
        
        [JsonProperty("screenHeight")]
        public long ScreenHeight
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Overriding view X position on screen in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
        /// </summary>
        
        [JsonProperty("positionX")]
        public long PositionX
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Overriding view Y position on screen in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
        /// </summary>
        
        [JsonProperty("positionY")]
        public long PositionY
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Screen orientation override.
        /// </summary>
        
        [JsonProperty("screenOrientation")]
        public BaristaLabs.ChromeDevTools.Runtime.Emulation.ScreenOrientation ScreenOrientation
        {
            get;
            set;
        }
    
    }

    public sealed class SetDeviceMetricsOverrideCommandResponse : ICommandResponse
    {
    
    }
}