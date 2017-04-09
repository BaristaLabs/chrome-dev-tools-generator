namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Force the page stop all navigations and pending resource fetches.
    /// </summary>
    public sealed class StopLoadingCommand : ICommand<StopLoadingCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.stopLoading";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StopLoadingCommandResponse : ICommandResponse
    {
    
    }
}