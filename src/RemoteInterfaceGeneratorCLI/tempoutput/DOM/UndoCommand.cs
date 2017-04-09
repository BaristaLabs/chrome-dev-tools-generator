namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Undoes the last performed action.
    /// </summary>
    public sealed class UndoCommand : ICommand<UndoCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.undo";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class UndoCommandResponse : ICommandResponse
    {
    
    }
}