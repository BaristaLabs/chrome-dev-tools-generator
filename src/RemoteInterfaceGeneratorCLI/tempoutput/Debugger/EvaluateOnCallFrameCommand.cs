namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Evaluates expression on a given call frame.
    /// </summary>
    public sealed class EvaluateOnCallFrameCommand : ICommand<EvaluateOnCallFrameCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.evaluateOnCallFrame";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Call frame identifier to evaluate on.
        /// </summary>
        
        [JsonProperty("callFrameId")]
        public string CallFrameId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Expression to evaluate.
        /// </summary>
        
        [JsonProperty("expression")]
        public string Expression
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// String object group name to put result into (allows rapid releasing resulting object handles using <code>releaseObjectGroup</code>).
        /// </summary>
        
        [JsonProperty("objectGroup")]
        public string ObjectGroup
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Specifies whether command line API should be available to the evaluated expression, defaults to false.
        /// </summary>
        
        [JsonProperty("includeCommandLineAPI")]
        public bool IncludeCommandLineAPI
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides <code>setPauseOnException</code> state.
        /// </summary>
        
        [JsonProperty("silent")]
        public bool Silent
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether the result is expected to be a JSON object that should be sent by value.
        /// </summary>
        
        [JsonProperty("returnByValue")]
        public bool ReturnByValue
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether preview should be generated for the result.
        /// </summary>
        
        [JsonProperty("generatePreview")]
        public bool GeneratePreview
        {
            get;
            set;
        }
    
    }

    public sealed class EvaluateOnCallFrameCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Object wrapper for the evaluation result.
        ///</summary>
        
        [JsonProperty("result")]
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.RemoteObject Result
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Exception details.
        ///</summary>
        
        [JsonProperty("exceptionDetails")]
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.ExceptionDetails ExceptionDetails
        {
            get;
            set;
        }
    
    }
}