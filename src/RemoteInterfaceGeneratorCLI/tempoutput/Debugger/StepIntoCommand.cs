namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Steps into the function call.
    /// </summary>
    public sealed class StepIntoCommand : ICommand<StepIntoCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.stepInto";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StepIntoCommandResponse : ICommandResponse
    {
    
    }
}