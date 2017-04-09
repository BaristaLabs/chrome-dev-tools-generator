namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Stack entry for runtime errors and assertions.
    /// </summary>
    public sealed class CallFrame
    {
    
        /// <summary>
        /// JavaScript function name.
        ///</summary>
        public string FunctionName
        {
            get;
            set;
        }
    
        /// <summary>
        /// JavaScript script id.
        ///</summary>
        public string ScriptId
        {
            get;
            set;
        }
    
        /// <summary>
        /// JavaScript script name or url.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// JavaScript script line number (0-based).
        ///</summary>
        public long LineNumber
        {
            get;
            set;
        }
    
        /// <summary>
        /// JavaScript script column number (0-based).
        ///</summary>
        public long ColumnNumber
        {
            get;
            set;
        }
    
    }
}