namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Re-does the last undone action.
    /// </summary>
    public sealed class RedoCommand : ICommand<RedoCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.redo";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class RedoCommandResponse : ICommandResponse
    {
    
    }
}