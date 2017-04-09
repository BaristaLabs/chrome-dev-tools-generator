namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets a specified page scale factor.
    /// </summary>
    public sealed class SetPageScaleFactorCommand : ICommand<SetPageScaleFactorCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setPageScaleFactor";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Page scale factor.
        /// </summary>
        
        [JsonProperty("pageScaleFactor")]
        public double PageScaleFactor
        {
            get;
            set;
        }
    
    }

    public sealed class SetPageScaleFactorCommandResponse : ICommandResponse
    {
    
    }
}