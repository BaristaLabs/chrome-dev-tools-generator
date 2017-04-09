namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    /// <summary>
    /// Location in the source code.
    /// </summary>
    public sealed class ScriptPosition
    {
    
        /// <summary>
        /// 
        ///</summary>
        public long LineNumber
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public long ColumnNumber
        {
            get;
            set;
        }
    
    }
}