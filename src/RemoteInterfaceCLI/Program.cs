namespace RemoteInterfaceCLI
{
    using BaristaLabs.ChromeDevTools.RemoteInterface;
    using BaristaLabs.ChromeDevTools.RemoteInterface.DebuggerProtocol;
    using EntryPoint;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using NJsonSchema;
    using NJsonSchema.Generation;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var cliArguments = Cli.Parse<CliArguments>(args);
            MainAsync(cliArguments).GetAwaiter().GetResult();
        }

        public static async Task MainAsync(CliArguments args)
        {
            JObject protocolData;

            if (args.ForceDownload || !File.Exists(args.ProtocolPath))
            {
                Console.WriteLine("Generating new protocol definition...");

                using (var chrome = ChromeFactory.OpenChrome())
                {
                    protocolData = await chrome.GetProtocolDefinitionForCurrentChromeVersion();
                }

                File.WriteAllText(args.ProtocolPath, JsonConvert.SerializeObject(protocolData, Formatting.Indented));
            }
            else
            {
                var protocolJson = File.ReadAllText(args.ProtocolPath);
                protocolData = JObject.Parse(protocolJson);
            }

            //Validate that the protocol data matches our current class object.
            var protocolSchema = await JsonSchema4.FromTypeAsync<ProtocolDefinition>(new JsonSchemaGeneratorSettings() { FlattenInheritanceHierarchy = true });
            var errors = protocolSchema.Validate(protocolData);
            if (errors.Count > 0)
                throw new InvalidOperationException("Protocol Definition data does not validate against Protocol Definition Class Library. Ensure that all properties have been added.");

            var protocolDefinition = protocolData.ToObject<ProtocolDefinition>(new JsonSerializer() { MetadataPropertyHandling = MetadataPropertyHandling.Ignore });

            //Begin the code generation process.
            //Delete the output folder if it exists.
            if (Directory.Exists(args.OutputPath))
            {
                Directory.Delete(args.OutputPath, true);
            }

            var directoryInfo = Directory.CreateDirectory(args.OutputPath);

            protocolDefinition.GenerateCode(new CodeGenerationSettings()
            {
                OutputPath = args.OutputPath,
                RootNamespace = args.RootNamespace,
                TemplatePath = $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\\templates",
            });

            //Completed.
            Console.WriteLine("All done!");
        }
    }
}