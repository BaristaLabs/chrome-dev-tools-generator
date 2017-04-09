namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns manifest URL for document in the given frame.
    /// </summary>
    public sealed class GetManifestForFrameCommand : ICommand<GetManifestForFrameCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "ApplicationCache.getManifestForFrame";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the frame containing document whose manifest is retrieved.
        /// </summary>
        
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    
    }

    public sealed class GetManifestForFrameCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Manifest URL for document in the given frame.
        ///</summary>
        
        [JsonProperty("manifestURL")]
        public string ManifestURL
        {
            get;
            set;
        }
    
    }
}