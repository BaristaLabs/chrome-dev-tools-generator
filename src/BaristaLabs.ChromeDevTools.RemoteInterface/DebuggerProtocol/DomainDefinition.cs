namespace BaristaLabs.ChromeDevTools.RemoteInterface.DebuggerProtocol
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public sealed class DomainDefinition : ProtocolDefinitionItem
    {
        public DomainDefinition()
        {
            Dependencies = new HashSet<string>();

            Types = new Collection<TypeDefinition>();
            Events = new Collection<EventDefinition>();
            Commands = new Collection<CommandDefinition>();
        }

        [JsonProperty(PropertyName = "domain")]
        public override string Name
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "types")]
        public ICollection<TypeDefinition> Types
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "commands")]
        public ICollection<CommandDefinition> Commands
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "events")]
        public ICollection<EventDefinition> Events
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "dependencies")]
        public ICollection<string> Dependencies
        {
            get;
            set;
        }

        public CommandDefinition GetCommand(string name)
        {
            return Commands.SingleOrDefault(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase));
        }

        public TypeDefinition GetType(string name)
        {
            return Types.SingleOrDefault(t => string.Equals(t.Name, name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
