namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Navigates current page to the given history entry.
    /// </summary>
    public sealed class NavigateToHistoryEntryCommand : ICommand<NavigateToHistoryEntryCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.navigateToHistoryEntry";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Unique id of the entry to navigate to.
        /// </summary>
        
        [JsonProperty("entryId")]
        public long EntryId
        {
            get;
            set;
        }
    
    }

    public sealed class NavigateToHistoryEntryCommandResponse : ICommandResponse
    {
    
    }
}