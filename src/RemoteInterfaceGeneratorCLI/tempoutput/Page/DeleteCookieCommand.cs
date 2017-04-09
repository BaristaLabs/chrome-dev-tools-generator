namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Deletes browser cookie with given name, domain and path.
    /// </summary>
    public sealed class DeleteCookieCommand : ICommand<DeleteCookieCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.deleteCookie";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Name of the cookie to remove.
        /// </summary>
        
        [JsonProperty("cookieName")]
        public string CookieName
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// URL to match cooke domain and path.
        /// </summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
    }

    public sealed class DeleteCookieCommandResponse : ICommandResponse
    {
    
    }
}