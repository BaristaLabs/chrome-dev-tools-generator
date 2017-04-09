namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    /// <summary>
    /// Profile node. Holds callsite information, execution statistics and child nodes.
    /// </summary>
    public sealed class ProfileNode
    {
    
        /// <summary>
        /// Unique id of the node.
        ///</summary>
        public long Id
        {
            get;
            set;
        }
    
        /// <summary>
        /// Function location.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.CallFrame CallFrame
        {
            get;
            set;
        }
    
        /// <summary>
        /// Number of samples where this node was on top of the call stack.
        ///</summary>
        public long HitCount
        {
            get;
            set;
        }
    
        /// <summary>
        /// Child node ids.
        ///</summary>
        public long[] Children
        {
            get;
            set;
        }
    
        /// <summary>
        /// The reason of being not optimized. The function may be deoptimized or marked as don't optimize.
        ///</summary>
        public string DeoptReason
        {
            get;
            set;
        }
    
        /// <summary>
        /// An array of source position ticks.
        ///</summary>
        public PositionTickInfo[] PositionTicks
        {
            get;
            set;
        }
    
    }
}