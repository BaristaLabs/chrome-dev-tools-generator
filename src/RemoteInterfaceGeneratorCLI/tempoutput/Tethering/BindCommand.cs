namespace BaristaLabs.ChromeDevTools.Runtime.Tethering
{
    using Newtonsoft.Json;

    /// <summary>
    /// Request browser port binding.
    /// </summary>
    public sealed class BindCommand : ICommand<BindCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Tethering.bind";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Port number to bind.
        /// </summary>
        
        [JsonProperty("port")]
        public long Port
        {
            get;
            set;
        }
    
    }

    public sealed class BindCommandResponse : ICommandResponse
    {
    
    }
}