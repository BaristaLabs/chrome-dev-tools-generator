namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Issued when console API was called.
    /// </summary>
    public sealed class ConsoleAPICalledEvent : IEvent
    {
    
        
        /// <summary>
        /// Type of the call.
        /// </summary>
        
        public string Type
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Call arguments.
        /// </summary>
        
        public RemoteObject[] Args
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Identifier of the context where the call was made.
        /// </summary>
        
        public long ExecutionContextId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Call timestamp.
        /// </summary>
        
        public double Timestamp
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Stack trace captured when the call was made.
        /// </summary>
        
        public StackTrace StackTrace
        {
            get;
            set;
        }
    
    }
}