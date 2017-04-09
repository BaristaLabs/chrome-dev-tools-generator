namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    /// <summary>
    /// Sampling Heap Profile node. Holds callsite information, allocation statistics and child nodes.
    /// </summary>
    public sealed class SamplingHeapProfileNode
    {
    
        /// <summary>
        /// Function location.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.CallFrame CallFrame
        {
            get;
            set;
        }
    
        /// <summary>
        /// Allocations size in bytes for the node excluding children.
        ///</summary>
        public double SelfSize
        {
            get;
            set;
        }
    
        /// <summary>
        /// Child nodes.
        ///</summary>
        public SamplingHeapProfileNode[] Children
        {
            get;
            set;
        }
    
    }
}