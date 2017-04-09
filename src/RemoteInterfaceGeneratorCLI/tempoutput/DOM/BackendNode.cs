namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Backend node with a friendly name.
    /// </summary>
    public sealed class BackendNode
    {
    
        /// <summary>
        /// <code>Node</code>'s nodeType.
        ///</summary>
        public long NodeType
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Node</code>'s nodeName.
        ///</summary>
        public string NodeName
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public long BackendNodeId
        {
            get;
            set;
        }
    
    }
}