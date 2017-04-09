namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns navigation history for the current page.
    /// </summary>
    public sealed class GetNavigationHistoryCommand : ICommand<GetNavigationHistoryCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getNavigationHistory";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetNavigationHistoryCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Index of the current navigation history entry.
        ///</summary>
        
        [JsonProperty("currentIndex")]
        public long CurrentIndex
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Array of navigation history entries.
        ///</summary>
        
        [JsonProperty("entries")]
        public NavigationEntry[] Entries
        {
            get;
            set;
        }
    
    }
}