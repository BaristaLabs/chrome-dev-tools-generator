namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Discards collected exceptions and console API calls.
    /// </summary>
    public sealed class DiscardConsoleEntriesCommand : ICommand<DiscardConsoleEntriesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.discardConsoleEntries";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class DiscardConsoleEntriesCommandResponse : ICommandResponse
    {
    
    }
}