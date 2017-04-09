namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    /// <summary>
    /// Object event listener.
    /// </summary>
    public sealed class EventListener
    {
    
        /// <summary>
        /// <code>EventListener</code>'s type.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>EventListener</code>'s useCapture.
        ///</summary>
        public bool UseCapture
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>EventListener</code>'s passive flag.
        ///</summary>
        public bool Passive
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>EventListener</code>'s once flag.
        ///</summary>
        public bool Once
        {
            get;
            set;
        }
    
        /// <summary>
        /// Script id of the handler code.
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
    
        /// <summary>
        /// Event handler function value.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.RemoteObject Handler
        {
            get;
            set;
        }
    
        /// <summary>
        /// Event original handler function value.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.RemoteObject OriginalHandler
        {
            get;
            set;
        }
    
        /// <summary>
        /// Event listener remove function.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.RemoteObject RemoveFunction
        {
            get;
            set;
        }
    
    }
}