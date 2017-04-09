namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables database tracking, database events will now be delivered to the client.
    /// </summary>
    public sealed class EnableCommand : ICommand<EnableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Database.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class EnableCommandResponse : ICommandResponse
    {
    
    }
}