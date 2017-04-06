namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using System.Collections.Generic;

    public interface ICodeGenerator<T>
        where T : IDefinition
    {
        IDictionary<string, string> GenerateCode(T item, dynamic options);
    }
}