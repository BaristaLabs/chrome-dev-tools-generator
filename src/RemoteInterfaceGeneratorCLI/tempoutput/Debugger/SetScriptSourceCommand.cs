namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Edits JavaScript source live.
    /// </summary>
    public sealed class SetScriptSourceCommand : ICommand<SetScriptSourceCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.setScriptSource";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the script to edit.
        /// </summary>
        
        [JsonProperty("scriptId")]
        public string ScriptId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// New content of the script.
        /// </summary>
        
        [JsonProperty("scriptSource")]
        public string ScriptSource
        {
            get;
            set;
        }
    
        
        /// <summary>
        ///  If true the change will not actually be applied. Dry run may be used to get result description without actually modifying the code.
        /// </summary>
        
        [JsonProperty("dryRun")]
        public bool DryRun
        {
            get;
            set;
        }
    
    }

    public sealed class SetScriptSourceCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// New stack trace in case editing has happened while VM was stopped.
        ///</summary>
        
        [JsonProperty("callFrames")]
        public CallFrame[] CallFrames
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether current call stack  was modified after applying the changes.
        ///</summary>
        
        [JsonProperty("stackChanged")]
        public bool StackChanged
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Async stack trace, if any.
        ///</summary>
        
        [JsonProperty("asyncStackTrace")]
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.StackTrace AsyncStackTrace
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Exception details if any.
        ///</summary>
        
        [JsonProperty("exceptionDetails")]
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.ExceptionDetails ExceptionDetails
        {
            get;
            set;
        }
    
    }
}