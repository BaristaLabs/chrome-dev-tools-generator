namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all browser cookies for the current URL. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
    /// </summary>
    public sealed class GetCookiesCommand : ICommand<GetCookiesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.getCookies";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetCookiesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Array of cookie objects.
        ///</summary>
        
        [JsonProperty("cookies")]
        public Cookie[] Cookies
        {
            get;
            set;
        }
    
    }
}