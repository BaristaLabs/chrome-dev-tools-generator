namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets node HTML markup, returns new node id.
    /// </summary>
    public sealed class SetOuterHTMLCommand : ICommand<SetOuterHTMLCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.setOuterHTML";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to set markup for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Outer HTML markup to set.
        /// </summary>
        
        [JsonProperty("outerHTML")]
        public string OuterHTML
        {
            get;
            set;
        }
    
    }

    public sealed class SetOuterHTMLCommandResponse : ICommandResponse
    {
    
    }
}