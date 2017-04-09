namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Tells inspected instance to run if it was waiting for debugger to attach.
    /// </summary>
    public sealed class RunIfWaitingForDebuggerCommand : ICommand<RunIfWaitingForDebuggerCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.runIfWaitingForDebugger";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class RunIfWaitingForDebuggerCommandResponse : ICommandResponse
    {
    
    }
}