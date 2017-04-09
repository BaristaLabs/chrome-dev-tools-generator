namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears browser cache.
    /// </summary>
    public sealed class ClearBrowserCacheCommand : ICommand<ClearBrowserCacheCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.clearBrowserCache";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ClearBrowserCacheCommandResponse : ICommandResponse
    {
    
    }
}