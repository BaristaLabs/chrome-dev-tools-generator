namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Searches for given string in script content.
    /// </summary>
    public sealed class SearchInContentCommand : ICommand<SearchInContentCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.searchInContent";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the script to search in.
        /// </summary>
        
        [JsonProperty("scriptId")]
        public string ScriptId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// String to search for.
        /// </summary>
        
        [JsonProperty("query")]
        public string Query
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If true, search is case sensitive.
        /// </summary>
        
        [JsonProperty("caseSensitive")]
        public bool CaseSensitive
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If true, treats string parameter as regex.
        /// </summary>
        
        [JsonProperty("isRegex")]
        public bool IsRegex
        {
            get;
            set;
        }
    
    }

    public sealed class SearchInContentCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// List of search matches.
        ///</summary>
        
        [JsonProperty("result")]
        public SearchMatch[] Result
        {
            get;
            set;
        }
    
    }
}