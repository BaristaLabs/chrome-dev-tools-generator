namespace RemoteInterfaceGeneratorCLI
{
    using EntryPoint;

    public class CliArguments : BaseCliArguments
    {
        private const string DefaultChromeDebuggingProtocolSchemaPath = "chrome-debugging-protocol-schema.json";
        private const string DefaultChromeDebuggingProtocolPath = "chrome-debugging-protocol.json";

        private const string DefaultOutputPath = "./OutputProtocol";
        private const string DefaultSettingsPath = "./Templates/settings.json";
        private const string DefaultRootNamespace = "BaristaLabs.ChromeDevTools";

        public CliArguments()
            : base("RemoteInterfaceCLI")
        {
            ProtocolPath = DefaultChromeDebuggingProtocolPath;
            Settings = DefaultSettingsPath;
            OutputPath = DefaultOutputPath;
        }

        [Option(ShortName: 'f',
                LongName: "force-download")]
        [Help("Forces the Chrome Protocol Definition to be downloaded from source even if it already exists.")]
        public bool ForceDownload
        {
            get;
            set;
        }

        [OptionParameter(ShortName: 'o',
                LongName: "outputPath")]
        [Help("Indicates the folder that will contain the generated class library [Default: ./OutputProtocol]")]
        public string OutputPath
        {
            get;
            set;
        }

        [OptionParameter(ShortName: 'p',
                LongName: "protocol-path")]
        [Help("Indicates the path to the Chrome Debugging Protocol JSON file to use. [Default: chrome-debugging-protocol.json]")]
        public string ProtocolPath
        {
            get;
            set;
        }

        [OptionParameter(ShortName: 's',
                LongName: "settings")]
        [Help("Indicates the path to the code generation settings file. [Default: ./Templates/settings.json]")]
        public string Settings
        {
            get;
            set;
        }
    }

}
