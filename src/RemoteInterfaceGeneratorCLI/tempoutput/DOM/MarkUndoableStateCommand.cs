namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Marks last undoable state.
    /// </summary>
    public sealed class MarkUndoableStateCommand : ICommand<MarkUndoableStateCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.markUndoableState";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class MarkUndoableStateCommandResponse : ICommandResponse
    {
    
    }
}