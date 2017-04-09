namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// Displays native dialog with the certificate details.
    /// </summary>
    public sealed class ShowCertificateViewerCommand : ICommand<ShowCertificateViewerCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Security.showCertificateViewer";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ShowCertificateViewerCommandResponse : ICommandResponse
    {
    
    }
}