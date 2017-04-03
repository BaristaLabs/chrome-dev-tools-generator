namespace BaristaLabs.ChromeDevTools.RemoteInterface.Generator
{
    using System.Collections.Generic;

    public interface ICodeGenerator
    {
        IDictionary<string, string> GenerateCode(CodeGenerationSettings settings, dynamic options);
    }
}
