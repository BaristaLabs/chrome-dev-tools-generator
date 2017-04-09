namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns search results from given <code>fromIndex</code> to given <code>toIndex</code> from the sarch with the given identifier.
    /// </summary>
    public sealed class GetSearchResultsCommand : ICommand<GetSearchResultsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getSearchResults";
        
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
    
        
        /// <summary>
        /// Start index of the search result to be returned.
        /// </summary>
        
        [JsonProperty("fromIndex")]
        public long FromIndex
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// End index of the search result to be returned.
        /// </summary>
        
        [JsonProperty("toIndex")]
        public long ToIndex
        {
            get;
            set;
        }
    
    }

    public sealed class GetSearchResultsCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Ids of the search result nodes.
        ///</summary>
        
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    
    }
}