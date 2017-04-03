namespace RemoteInterfaceGeneratorCLI
{
    using BaristaLabs.ChromeDevTools;
    using BaristaLabs.ChromeDevTools.RemoteInterface.Generator;
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using EntryPoint;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using NJsonSchema;
    using NJsonSchema.Generation;
    using System;
    using System.IO;
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
                Console.WriteLine("Obtaining protocol definition from installed Chrome version...");

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
            Console.WriteLine("Generating protocol definition project...");
            if (Directory.Exists(args.OutputPath))
            {
                Directory.Delete(args.OutputPath, true);
            }

            var directoryInfo = Directory.CreateDirectory(args.OutputPath);

            if (!Directory.Exists(args.TemplatesPath))
                throw new FileNotFoundException($"The specified templates path ({args.TemplatesPath}) could not be found. Please check that the templates path exists and is populated with templates.");

            var codeFiles = protocolDefinition.GenerateCode(new CodeGenerationSettings()
            {
                OutputPath = args.OutputPath,
                RootNamespace = args.RootNamespace,
                TemplatesPath = args.TemplatesPath
            }, null);

            foreach(var codeFile in codeFiles)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(codeFile.Key));
                File.WriteAllText(codeFile.Key, codeFile.Value);
            }

            //Completed.
            Console.WriteLine("All done!");
        }
    }
}