namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    /// <summary>
    /// Fired when virtual machine fails to parse the script.
    /// </summary>
    public sealed class ScriptFailedToParseEvent : IEvent
    {
    
        
        /// <summary>
        /// Identifier of the script parsed.
        /// </summary>
        
        public string ScriptId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// URL or name of the script parsed (if any).
        /// </summary>
        
        public string Url
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Line offset of the script within the resource with given URL (for script tags).
        /// </summary>
        
        public long StartLine
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Column offset of the script within the resource with given URL.
        /// </summary>
        
        public long StartColumn
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Last line of the script.
        /// </summary>
        
        public long EndLine
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Length of the last line of the script.
        /// </summary>
        
        public long EndColumn
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Specifies script creation context.
        /// </summary>
        
        public long ExecutionContextId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Content hash of the script.
        /// </summary>
        
        public string Hash
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Embedder-specific auxiliary data.
        /// </summary>
        
        public object ExecutionContextAuxData
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// URL of source map associated with script (if any).
        /// </summary>
        
        public string SourceMapURL
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// True, if this script has sourceURL.
        /// </summary>
        
        public bool HasSourceURL
        {
            get;
            set;
        }
    
    }
}