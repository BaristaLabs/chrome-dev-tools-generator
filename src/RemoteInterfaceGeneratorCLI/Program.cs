namespace RemoteInterfaceGeneratorCLI
{
    using BaristaLabs.ChromeDevTools;
    using BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen;
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using EntryPoint;
    using Microsoft.Extensions.DependencyInjection;
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

            //Load Settings.
            if (!File.Exists(cliArguments.Settings))
                throw new FileNotFoundException($"The specified settings file ({cliArguments.Settings}) could not be found. Please check that the settings file exists.");

            var settingsJson = File.ReadAllText(cliArguments.Settings);
            var settings = JsonConvert.DeserializeObject<CodeGenerationSettings>(settingsJson);

            // setup our DI
            var serviceProvider = new ServiceCollection()
                .AddCodeGenerationServices(settings)
                .BuildServiceProvider();

            //Get the protocol Data.
            var protocolDefinitionData = GetProtocolDefinitionData(cliArguments).GetAwaiter().GetResult();

            //Validate that the protocol data matches our current class object.
            var protocolSchema = JsonSchema4.FromTypeAsync<ProtocolDefinition>(new JsonSchemaGeneratorSettings() { FlattenInheritanceHierarchy = true }).GetAwaiter().GetResult();
            var errors = protocolSchema.Validate(protocolDefinitionData);
            if (errors.Count > 0)
                throw new InvalidOperationException("Protocol Definition data does not validate against Protocol Definition Class Library. Ensure that all properties have been added.");

            var protocolDefinition = protocolDefinitionData.ToObject<ProtocolDefinition>(new JsonSerializer() { MetadataPropertyHandling = MetadataPropertyHandling.Ignore });

            //Begin the code generation process.
            //Delete the output folder if it exists.
            Console.WriteLine("Generating protocol definition project...");
            if (Directory.Exists(cliArguments.OutputPath))
            {
                Directory.Delete(cliArguments.OutputPath, true);
            }

            var directoryInfo = Directory.CreateDirectory(cliArguments.OutputPath);

            var protocolGenerator = serviceProvider.GetRequiredService<ICodeGenerator<ProtocolDefinition>>();
            var codeFiles = protocolGenerator.GenerateCode(protocolDefinition, null);

            foreach (var codeFile in codeFiles)
            {
                var targetFilePath = Path.GetFullPath($"{cliArguments.OutputPath}{codeFile.Key}");
                Directory.CreateDirectory(Path.GetDirectoryName(targetFilePath));
                File.WriteAllText(targetFilePath, codeFile.Value);
            }

            //Completed.
            Console.WriteLine("All done!");
        }

        /// <summary>
        /// Returns a merged ProtocolDefinition JObject
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<JObject> GetProtocolDefinitionData(CliArguments args)
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

            return protocolData;
        }
    }
}