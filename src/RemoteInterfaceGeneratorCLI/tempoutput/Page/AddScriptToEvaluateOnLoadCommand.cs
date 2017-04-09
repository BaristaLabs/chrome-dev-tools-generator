namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class AddScriptToEvaluateOnLoadCommand : ICommand<AddScriptToEvaluateOnLoadCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.addScriptToEvaluateOnLoad";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the scriptSource
        /// </summary>
        
        [JsonProperty("scriptSource")]
        public string ScriptSource
        {
            get;
            set;
        }
    
    }

    public sealed class AddScriptToEvaluateOnLoadCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Identifier of the added script.
        ///</summary>
        
        [JsonProperty("identifier")]
        public string Identifier
        {
            get;
            set;
        }
    
    }
}