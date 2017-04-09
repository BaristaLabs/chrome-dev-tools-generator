namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Resumes JavaScript execution.
    /// </summary>
    public sealed class ResumeCommand : ICommand<ResumeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.resume";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ResumeCommandResponse : ICommandResponse
    {
    
    }
}