namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Tells whether clearing browser cookies is supported.
    /// </summary>
    public sealed class CanClearBrowserCookiesCommand : ICommand<CanClearBrowserCookiesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.canClearBrowserCookies";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class CanClearBrowserCookiesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// True if browser cookies can be cleared.
        ///</summary>
        
        [JsonProperty("result")]
        public bool Result
        {
            get;
            set;
        }
    
    }
}