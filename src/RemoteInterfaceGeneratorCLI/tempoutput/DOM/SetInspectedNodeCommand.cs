namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
    /// </summary>
    public sealed class SetInspectedNodeCommand : ICommand<SetInspectedNodeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.setInspectedNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// DOM node id to be accessible by means of $x command line API.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class SetInspectedNodeCommandResponse : ICommandResponse
    {
    
    }
}