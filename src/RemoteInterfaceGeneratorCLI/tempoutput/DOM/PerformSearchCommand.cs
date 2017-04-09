namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Searches for a given string in the DOM tree. Use <code>getSearchResults</code> to access search results or <code>cancelSearch</code> to end this search session.
    /// </summary>
    public sealed class PerformSearchCommand : ICommand<PerformSearchCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.performSearch";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Plain text or query selector or XPath search query.
        /// </summary>
        
        [JsonProperty("query")]
        public string Query
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// True to search in user agent shadow DOM.
        /// </summary>
        
        [JsonProperty("includeUserAgentShadowDOM")]
        public bool IncludeUserAgentShadowDOM
        {
            get;
            set;
        }
    
    }

    public sealed class PerformSearchCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Unique search session identifier.
        ///</summary>
        
        [JsonProperty("searchId")]
        public string SearchId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Number of search results.
        ///</summary>
        
        [JsonProperty("resultCount")]
        public long ResultCount
        {
            get;
            set;
        }
    
    }
}