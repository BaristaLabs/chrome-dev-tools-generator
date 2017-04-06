namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using Mustache;
    using System.Collections.Generic;
    using System.IO;
    using Humanizer;

    public class DehumanizeTagDefinition : ContentTagDefinition
    {
        public DehumanizeTagDefinition()
            : base("dehumanize")
        {
        }

        public override IEnumerable<NestedContext> GetChildContext(TextWriter writer, Scope keyScope, Dictionary<string, object> arguments, Scope contextScope)
        {
            NestedContext context = new NestedContext()
            {
                KeyScope = keyScope,
                Writer = new StringWriter(),
                WriterNeedsConsidated = true,
            };
            yield return context;
        }

        public override IEnumerable<TagParameter> GetChildContextParameters()
        {
            return new TagParameter[] { new TagParameter("collection") };
        }

        public override string ConsolidateWriter(TextWriter writer, Dictionary<string, object> arguments)
        {
            return writer.ToString().Dehumanize();
        }
    }
}
