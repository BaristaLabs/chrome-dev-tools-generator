namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns present frame / resource tree structure.
    /// </summary>
    public sealed class GetResourceTreeCommand : ICommand<GetResourceTreeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getResourceTree";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetResourceTreeCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Present frame / resource tree structure.
        ///</summary>
        
        [JsonProperty("frameTree")]
        public FrameResourceTree FrameTree
        {
            get;
            set;
        }
    
    }
}