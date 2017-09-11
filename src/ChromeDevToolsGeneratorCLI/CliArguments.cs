namespace ChromeDevToolsGeneratorCLI
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
            ProtocolSchemaPath = DefaultChromeDebuggingProtocolSchemaPath;
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

        [Option("force")]
        [Help("Forces the output directory to be overwritten")]
        public bool ForceOverwrite
        {
            get;
            set;
        }

        [Option("generate-protocol-schema")]
        [Help("Forces the protocol schema to be generated from the current class definition")]
        public bool GenerateProtocolSchema
        {
            get;
            set;
        }

        [OptionParameter(ShortName: 'o',
                LongName: "output-path")]
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

        [OptionParameter(ShortName: 'd',
                LongName: "protocol-schema-path")]
        [Help("Indicates the path to the Chrome Debugging Protocol JSON Schema file to use. [Default: chrome-debugging-protocol-schema.json]")]
        public string ProtocolSchemaPath
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
