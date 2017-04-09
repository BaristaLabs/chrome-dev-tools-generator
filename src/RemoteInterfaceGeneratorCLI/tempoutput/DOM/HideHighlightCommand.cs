namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Hides DOM node highlight.
    /// </summary>
    public sealed class HideHighlightCommand : ICommand<HideHighlightCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.hideHighlight";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class HideHighlightCommandResponse : ICommandResponse
    {
    
    }
}