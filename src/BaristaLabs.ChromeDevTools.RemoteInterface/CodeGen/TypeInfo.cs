namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    /// <summary>
    /// Represents information about a Chrome Debugger Protocol type.
    /// </summary>
    public sealed class TypeInfo
    {
        public string Namespace
        {
            get;
            set;
        }

        public bool IsPrimitive
        {
            get;
            set;
        }

        public string TypeName
        {
            get;
            set;
        }
    }
}
