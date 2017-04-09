namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Resets the visible area of the page to the original viewport, undoing any effects of the <code>forceViewport</code> command.
    /// </summary>
    public sealed class ResetViewportCommand : ICommand<ResetViewportCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.resetViewport";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ResetViewportCommandResponse : ICommandResponse
    {
    
    }
}