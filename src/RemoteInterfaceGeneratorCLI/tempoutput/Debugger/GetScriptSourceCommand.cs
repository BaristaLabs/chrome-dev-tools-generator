namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns source for the script with given id.
    /// </summary>
    public sealed class GetScriptSourceCommand : ICommand<GetScriptSourceCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.getScriptSource";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the script to get source for.
        /// </summary>
        
        [JsonProperty("scriptId")]
        public string ScriptId
        {
            get;
            set;
        }
    
    }

    public sealed class GetScriptSourceCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Script source.
        ///</summary>
        
        [JsonProperty("scriptSource")]
        public string ScriptSource
        {
            get;
            set;
        }
    
    }
}