namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Continues execution until specific location is reached.
    /// </summary>
    public sealed class ContinueToLocationCommand : ICommand<ContinueToLocationCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.continueToLocation";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Location to continue to.
        /// </summary>
        
        [JsonProperty("location")]
        public Location Location
        {
            get;
            set;
        }
    
    }

    public sealed class ContinueToLocationCommandResponse : ICommandResponse
    {
    
    }
}