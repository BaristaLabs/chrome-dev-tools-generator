namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables compositing tree inspection.
    /// </summary>
    public sealed class DisableCommand : ICommand<DisableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "LayerTree.disable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class DisableCommandResponse : ICommandResponse
    {
    
    }
}