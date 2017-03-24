namespace RemoteInterfaceCLI
{
    using BaristaLabs.ChromeDevTools.RemoteInterface;
    using BaristaLabs.ChromeDevTools.RemoteInterface.DebuggerProtocol;
    using Newtonsoft.Json;
    using NJsonSchema;
    using NJsonSchema.Generation;
    using System;
    using System.IO;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        public static async Task MainAsync(string[] args)
        {
            using (var chrome = ChromeFactory.OpenChrome())
            {
                Console.WriteLine("Generating new protocol definition...");
                var data = await chrome.GetProtocolDefinitionForCurrentChromeVersion();

                var protocolSchema = await JsonSchema4.FromTypeAsync<ProtocolDefinition>(new JsonSchemaGeneratorSettings() { FlattenInheritanceHierarchy = true });
                var errors = protocolSchema.Validate(data);
                if (errors.Count > 0)
                    throw new InvalidOperationException("Protocol Definition data does not validate against Protocol Definition Class Library. Ensure that all properties have been added.");

                File.WriteAllText("./output.jsc", protocolSchema.ToJson());
                File.WriteAllText("./output.json", JsonConvert.SerializeObject(data));
            }
        }
    }
}