namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Steps over the statement.
    /// </summary>
    public sealed class StepOverCommand : ICommand<StepOverCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.stepOver";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StepOverCommandResponse : ICommandResponse
    {
    
    }
}