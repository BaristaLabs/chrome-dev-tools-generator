namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns boxes for the currently selected nodes.
    /// </summary>
    public sealed class GetBoxModelCommand : ICommand<GetBoxModelCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getBoxModel";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to get box model for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class GetBoxModelCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Box model for the node.
        ///</summary>
        
        [JsonProperty("model")]
        public BoxModel Model
        {
            get;
            set;
        }
    
    }
}