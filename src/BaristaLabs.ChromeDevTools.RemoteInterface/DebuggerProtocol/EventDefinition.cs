namespace BaristaLabs.ChromeDevTools.RemoteInterface.DebuggerProtocol
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System;

    public sealed class EventDefinition : ProtocolDefinitionItem, ICodeGenerator
    {
        public EventDefinition()
        {
            Parameters = new Collection<TypeDefinition>();
        }

        [JsonProperty(PropertyName = "parameters")]
        public ICollection<TypeDefinition> Parameters
        {
            get;
            set;
        }

        public IDictionary<string, string> GenerateCode(CodeGenerationSettings settings, dynamic options)
        {
            throw new NotImplementedException();
        }
    }
}
