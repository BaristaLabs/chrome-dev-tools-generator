namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Reloads given page optionally ignoring the cache.
    /// </summary>
    public sealed class ReloadCommand : ICommand<ReloadCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.reload";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// If true, browser cache is ignored (as if the user pressed Shift+refresh).
        /// </summary>
        
        [JsonProperty("ignoreCache")]
        public bool IgnoreCache
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If set, the script will be injected into all frames of the inspected page after reload.
        /// </summary>
        
        [JsonProperty("scriptToEvaluateOnLoad")]
        public string ScriptToEvaluateOnLoad
        {
            get;
            set;
        }
    
    }

    public sealed class ReloadCommandResponse : ICommandResponse
    {
    
    }
}