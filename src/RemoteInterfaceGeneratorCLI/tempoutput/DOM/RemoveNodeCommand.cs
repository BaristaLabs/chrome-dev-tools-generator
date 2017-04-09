namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes node with given id.
    /// </summary>
    public sealed class RemoveNodeCommand : ICommand<RemoveNodeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.removeNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to remove.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class RemoveNodeCommandResponse : ICommandResponse
    {
    
    }
}