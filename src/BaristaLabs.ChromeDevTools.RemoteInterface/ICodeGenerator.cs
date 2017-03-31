namespace BaristaLabs.ChromeDevTools.RemoteInterface
{
    using System.Collections.Generic;

    public interface ICodeGenerator
    {
        IDictionary<string, string> GenerateCode(CodeGenerationSettings settings);
    }
}
