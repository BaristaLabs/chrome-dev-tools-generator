namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that a batch of nodes is sent to the caller given their backend node ids.
    /// </summary>
    public sealed class PushNodesByBackendIdsToFrontendCommand : ICommand<PushNodesByBackendIdsToFrontendCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.pushNodesByBackendIdsToFrontend";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The array of backend node ids.
        /// </summary>
        
        [JsonProperty("backendNodeIds")]
        public long[] BackendNodeIds
        {
            get;
            set;
        }
    
    }

    public sealed class PushNodesByBackendIdsToFrontendCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The array of ids of pushed nodes that correspond to the backend ids specified in backendNodeIds.
        ///</summary>
        
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    
    }
}