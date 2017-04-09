namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Calls function with given declaration on the given object. Object group of the result is inherited from the target object.
    /// </summary>
    public sealed class CallFunctionOnCommand : ICommand<CallFunctionOnCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.callFunctionOn";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the object to call function on.
        /// </summary>
        
        [JsonProperty("objectId")]
        public string ObjectId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Declaration of the function to call.
        /// </summary>
        
        [JsonProperty("functionDeclaration")]
        public string FunctionDeclaration
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Call arguments. All call arguments must belong to the same JavaScript world as the target object.
        /// </summary>
        
        [JsonProperty("arguments")]
        public CallArgument[] Arguments
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
        /// Whether execution should be treated as initiated by user in the UI.
        /// </summary>
        
        [JsonProperty("userGesture")]
        public bool UserGesture
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

    public sealed class CallFunctionOnCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Call result.
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