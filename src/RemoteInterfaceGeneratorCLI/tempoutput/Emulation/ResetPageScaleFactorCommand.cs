namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that page scale factor is reset to initial values.
    /// </summary>
    public sealed class ResetPageScaleFactorCommand : ICommand<ResetPageScaleFactorCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.resetPageScaleFactor";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ResetPageScaleFactorCommandResponse : ICommandResponse
    {
    
    }
}