namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Runs script with given id in a given context.
    /// </summary>
    public sealed class RunScriptCommand : ICommand<RunScriptCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.runScript";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the script to run.
        /// </summary>
        
        [JsonProperty("scriptId")]
        public string ScriptId
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
    
        
        /// <summary>
        /// Symbolic group name that can be used to release multiple objects.
        /// </summary>
        
        [JsonProperty("objectGroup")]
        public string ObjectGroup
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
        /// Determines whether Command Line API should be available during the evaluation.
        /// </summary>
        
        [JsonProperty("includeCommandLineAPI")]
        public bool IncludeCommandLineAPI
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether the result is expected to be a JSON object which should be sent by value.
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
    
        
        /// <summary>
        /// Whether execution should wait for promise to be resolved. If the result of evaluation is not a Promise, it's considered to be an error.
        /// </summary>
        
        [JsonProperty("awaitPromise")]
        public bool AwaitPromise
        {
            get;
            set;
        }
    
    }

    public sealed class RunScriptCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Run result.
        ///</summary>
        
        [JsonProperty("result")]
        public RemoteObject Result
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