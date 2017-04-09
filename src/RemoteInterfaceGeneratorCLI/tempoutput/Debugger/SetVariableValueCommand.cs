namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Changes value of variable in a callframe. Object-based scopes are not supported and must be mutated manually.
    /// </summary>
    public sealed class SetVariableValueCommand : ICommand<SetVariableValueCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.setVariableValue";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// 0-based number of scope as was listed in scope chain. Only 'local', 'closure' and 'catch' scope types are allowed. Other scopes could be manipulated manually.
        /// </summary>
        
        [JsonProperty("scopeNumber")]
        public long ScopeNumber
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Variable name.
        /// </summary>
        
        [JsonProperty("variableName")]
        public string VariableName
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// New variable value.
        /// </summary>
        
        [JsonProperty("newValue")]
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.CallArgument NewValue
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Id of callframe that holds variable.
        /// </summary>
        
        [JsonProperty("callFrameId")]
        public string CallFrameId
        {
            get;
            set;
        }
    
    }

    public sealed class SetVariableValueCommandResponse : ICommandResponse
    {
    
    }
}