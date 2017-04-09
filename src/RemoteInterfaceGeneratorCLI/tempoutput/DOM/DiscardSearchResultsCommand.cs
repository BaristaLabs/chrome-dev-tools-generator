namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Discards search results from the session with the given id. <code>getSearchResults</code> should no longer be called for that search.
    /// </summary>
    public sealed class DiscardSearchResultsCommand : ICommand<DiscardSearchResultsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.discardSearchResults";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Unique search session identifier.
        /// </summary>
        
        [JsonProperty("searchId")]
        public string SearchId
        {
            get;
            set;
        }
    
    }

    public sealed class DiscardSearchResultsCommandResponse : ICommandResponse
    {
    
    }
}