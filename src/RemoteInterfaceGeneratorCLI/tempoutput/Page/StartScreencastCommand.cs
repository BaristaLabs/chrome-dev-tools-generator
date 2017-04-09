namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Starts sending each frame using the <code>screencastFrame</code> event.
    /// </summary>
    public sealed class StartScreencastCommand : ICommand<StartScreencastCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.startScreencast";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Image compression format.
        /// </summary>
        
        [JsonProperty("format")]
        public string Format
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Compression quality from range [0..100].
        /// </summary>
        
        [JsonProperty("quality")]
        public long Quality
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Maximum screenshot width.
        /// </summary>
        
        [JsonProperty("maxWidth")]
        public long MaxWidth
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Maximum screenshot height.
        /// </summary>
        
        [JsonProperty("maxHeight")]
        public long MaxHeight
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Send every n-th frame.
        /// </summary>
        
        [JsonProperty("everyNthFrame")]
        public long EveryNthFrame
        {
            get;
            set;
        }
    
    }

    public sealed class StartScreencastCommandResponse : ICommandResponse
    {
    
    }
}