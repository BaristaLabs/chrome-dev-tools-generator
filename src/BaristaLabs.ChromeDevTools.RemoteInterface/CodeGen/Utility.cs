namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    /// <summary>
    /// Contains various utility methods.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Replaces tokens in the target path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="className"></param>
        /// <param name="context"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static string ReplaceTokensInPath(string path, string className, CodeGeneratorContext context, CodeGenerationSettings settings)
        {
            path = path.Replace("{{className}}", className);
            path = path.Replace("{{rootNamespace}}", settings.RootNamespace);
            path = path.Replace("{{templatePath}}", settings.TemplatesPath);
            path = path.Replace("{{domainName}}", context.Domain.Name);
            return path;
        }
    }
}
