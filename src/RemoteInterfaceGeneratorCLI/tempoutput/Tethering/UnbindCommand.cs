namespace BaristaLabs.ChromeDevTools.Runtime.Tethering
{
    using Newtonsoft.Json;

    /// <summary>
    /// Request browser port unbinding.
    /// </summary>
    public sealed class UnbindCommand : ICommand<UnbindCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Tethering.unbind";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Port number to unbind.
        /// </summary>
        
        [JsonProperty("port")]
        public long Port
        {
            get;
            set;
        }
    
    }

    public sealed class UnbindCommandResponse : ICommandResponse
    {
    
    }
}