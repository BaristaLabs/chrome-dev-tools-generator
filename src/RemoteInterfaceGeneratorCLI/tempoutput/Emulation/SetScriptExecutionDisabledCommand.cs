namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Switches script execution in the page.
    /// </summary>
    public sealed class SetScriptExecutionDisabledCommand : ICommand<SetScriptExecutionDisabledCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setScriptExecutionDisabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Whether script execution should be disabled in the page.
        /// </summary>
        
        [JsonProperty("value")]
        public bool Value
        {
            get;
            set;
        }
    
    }

    public sealed class SetScriptExecutionDisabledCommandResponse : ICommandResponse
    {
    
    }
}