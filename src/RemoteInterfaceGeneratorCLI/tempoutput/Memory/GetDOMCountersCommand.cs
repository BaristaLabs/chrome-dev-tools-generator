namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class GetDOMCountersCommand : ICommand<GetDOMCountersCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.getDOMCounters";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetDOMCountersCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Gets or sets the documents
        /// </summary>
        
        [JsonProperty("documents")]
        public long Documents
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the nodes
        /// </summary>
        
        [JsonProperty("nodes")]
        public long Nodes
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the jsEventListeners
        /// </summary>
        
        [JsonProperty("jsEventListeners")]
        public long JsEventListeners
        {
            get;
            set;
        }
    
    }
}