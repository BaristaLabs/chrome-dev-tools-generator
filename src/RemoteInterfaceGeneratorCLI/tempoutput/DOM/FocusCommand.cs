namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Focuses the given element.
    /// </summary>
    public sealed class FocusCommand : ICommand<FocusCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.focus";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to focus.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class FocusCommandResponse : ICommandResponse
    {
    
    }
}