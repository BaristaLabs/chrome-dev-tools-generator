namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Steps out of the function call.
    /// </summary>
    public sealed class StepOutCommand : ICommand<StepOutCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.stepOut";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StepOutCommandResponse : ICommandResponse
    {
    
    }
}