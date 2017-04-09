namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns relevant application cache data for the document in given frame.
    /// </summary>
    public sealed class GetApplicationCacheForFrameCommand : ICommand<GetApplicationCacheForFrameCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "ApplicationCache.getApplicationCacheForFrame";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the frame containing document whose application cache is retrieved.
        /// </summary>
        
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    
    }

    public sealed class GetApplicationCacheForFrameCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Relevant application cache data for the document in given frame.
        ///</summary>
        
        [JsonProperty("applicationCache")]
        public ApplicationCache ApplicationCache
        {
            get;
            set;
        }
    
    }
}