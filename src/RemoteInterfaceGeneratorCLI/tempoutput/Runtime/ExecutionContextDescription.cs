namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Description of an isolated world.
    /// </summary>
    public sealed class ExecutionContextDescription
    {
    
        /// <summary>
        /// Unique id of the execution context. It can be used to specify in which execution context script evaluation should be performed.
        ///</summary>
        public long Id
        {
            get;
            set;
        }
    
        /// <summary>
        /// Execution context origin.
        ///</summary>
        public string Origin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Human readable name describing given context.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Embedder-specific auxiliary data.
        ///</summary>
        public object AuxData
        {
            get;
            set;
        }
    
    }
}