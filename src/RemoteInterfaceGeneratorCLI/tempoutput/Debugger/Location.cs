namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    /// <summary>
    /// Location in the source code.
    /// </summary>
    public sealed class Location
    {
    
        /// <summary>
        /// Script identifier as reported in the <code>Debugger.scriptParsed</code>.
        ///</summary>
        public string ScriptId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Line number in the script (0-based).
        ///</summary>
        public long LineNumber
        {
            get;
            set;
        }
    
        /// <summary>
        /// Column number in the script (0-based).
        ///</summary>
        public long ColumnNumber
        {
            get;
            set;
        }
    
    }
}