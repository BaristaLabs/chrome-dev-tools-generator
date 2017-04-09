namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
    /// </summary>
    public sealed class GetAllCookiesCommand : ICommand<GetAllCookiesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.getAllCookies";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetAllCookiesCommandResponse : ICommandResponse
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