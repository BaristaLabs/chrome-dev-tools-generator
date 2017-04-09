namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears browser cookies.
    /// </summary>
    public sealed class ClearBrowserCookiesCommand : ICommand<ClearBrowserCookiesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.clearBrowserCookies";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ClearBrowserCookiesCommandResponse : ICommandResponse
    {
    
    }
}