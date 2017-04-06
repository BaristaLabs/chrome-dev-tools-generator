namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using System.Collections.Generic;

    public interface ICodeGenerator
    {
        IDictionary<string, string> GenerateCode(CodeGenerationSettings settings, dynamic options);
    }
}
