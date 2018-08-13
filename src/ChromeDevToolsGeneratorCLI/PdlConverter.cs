namespace ChromeDevToolsGeneratorCLI
{
    using IronPython.Hosting;
    using Microsoft.Scripting.Hosting;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Uses IronPython to convert the chromium protocol to other formats using the provided chromium pdl script
    /// </summary>
    /// <remarks>
    /// https://cs.chromium.org/chromium/src/third_party/inspector_protocol/
    /// </remarks>
    public class PdlConverter
    {
        private ScriptEngine Engine
        {
            get;
            set;
        }

        private dynamic Scope
        {
            get;
            set;
        }

        public PdlConverter(string script)
        {
            Engine = Python.CreateEngine();
            Scope = Engine.CreateScope();
            Engine.Execute(script, Scope);
        }

        public JObject ToJson(string protocol, string fileName)
        {
            var parsedProtocol = Scope.loads(protocol, fileName);
            var json = Scope.json.dumps(parsedProtocol);

            return JObject.Parse(json.ToString());
        }
    }
}
