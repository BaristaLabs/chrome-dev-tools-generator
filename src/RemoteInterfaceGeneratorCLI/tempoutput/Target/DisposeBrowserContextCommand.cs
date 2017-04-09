namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Deletes a BrowserContext, will fail of any open page uses it.
    /// </summary>
    public sealed class DisposeBrowserContextCommand : ICommand<DisposeBrowserContextCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.disposeBrowserContext";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the browserContextId
        /// </summary>
        
        [JsonProperty("browserContextId")]
        public string BrowserContextId
        {
            get;
            set;
        }
    
    }

    public sealed class DisposeBrowserContextCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Gets or sets the success
        /// </summary>
        
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }
    
    }
}