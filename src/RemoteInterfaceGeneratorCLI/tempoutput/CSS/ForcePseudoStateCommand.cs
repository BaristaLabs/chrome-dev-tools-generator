namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Ensures that the given node will have specified pseudo-classes whenever its style is computed by the browser.
    /// </summary>
    public sealed class ForcePseudoStateCommand : ICommand<ForcePseudoStateCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.forcePseudoState";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The element id for which to force the pseudo state.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Element pseudo classes to force when computing the element's style.
        /// </summary>
        
        [JsonProperty("forcedPseudoClasses")]
        public string[] ForcedPseudoClasses
        {
            get;
            set;
        }
    
    }

    public sealed class ForcePseudoStateCommandResponse : ICommandResponse
    {
    
    }
}