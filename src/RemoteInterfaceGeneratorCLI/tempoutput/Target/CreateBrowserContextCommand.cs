namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than one.
    /// </summary>
    public sealed class CreateBrowserContextCommand : ICommand<CreateBrowserContextCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.createBrowserContext";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class CreateBrowserContextCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The id of the context created.
        ///</summary>
        
        [JsonProperty("browserContextId")]
        public string BrowserContextId
        {
            get;
            set;
        }
    
    }
}