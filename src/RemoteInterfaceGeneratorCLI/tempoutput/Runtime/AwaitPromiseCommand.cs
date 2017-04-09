namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Add handler to promise with given promise object id.
    /// </summary>
    public sealed class AwaitPromiseCommand : ICommand<AwaitPromiseCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.awaitPromise";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the promise.
        /// </summary>
        
        [JsonProperty("promiseObjectId")]
        public string PromiseObjectId
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

    public sealed class AwaitPromiseCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Promise result. Will contain rejected value if promise was rejected.
        ///</summary>
        
        [JsonProperty("result")]
        public RemoteObject Result
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Exception details if stack strace is available.
        ///</summary>
        
        [JsonProperty("exceptionDetails")]
        public ExceptionDetails ExceptionDetails
        {
            get;
            set;
        }
    
    }
}