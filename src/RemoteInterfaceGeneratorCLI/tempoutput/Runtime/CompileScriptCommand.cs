namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Compiles expression.
    /// </summary>
    public sealed class CompileScriptCommand : ICommand<CompileScriptCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.compileScript";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Expression to compile.
        /// </summary>
        
        [JsonProperty("expression")]
        public string Expression
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Source url to be set for the script.
        /// </summary>
        
        [JsonProperty("sourceURL")]
        public string SourceURL
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Specifies whether the compiled script should be persisted.
        /// </summary>
        
        [JsonProperty("persistScript")]
        public bool PersistScript
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Specifies in which execution context to perform script run. If the parameter is omitted the evaluation will be performed in the context of the inspected page.
        /// </summary>
        
        [JsonProperty("executionContextId")]
        public long ExecutionContextId
        {
            get;
            set;
        }
    
    }

    public sealed class CompileScriptCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Id of the script.
        ///</summary>
        
        [JsonProperty("scriptId")]
        public string ScriptId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Exception details.
        ///</summary>
        
        [JsonProperty("exceptionDetails")]
        public ExceptionDetails ExceptionDetails
        {
            get;
            set;
        }
    
    }
}