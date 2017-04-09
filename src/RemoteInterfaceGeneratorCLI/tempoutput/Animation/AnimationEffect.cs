namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    /// <summary>
    /// AnimationEffect instance
    /// </summary>
    public sealed class AnimationEffect
    {
    
        /// <summary>
        /// <code>AnimationEffect</code>'s delay.
        ///</summary>
        public double Delay
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s end delay.
        ///</summary>
        public double EndDelay
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s iteration start.
        ///</summary>
        public double IterationStart
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s iterations.
        ///</summary>
        public double Iterations
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s iteration duration.
        ///</summary>
        public double Duration
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s playback direction.
        ///</summary>
        public string Direction
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s fill mode.
        ///</summary>
        public string Fill
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s target node.
        ///</summary>
        public long BackendNodeId
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s keyframes.
        ///</summary>
        public KeyframesRule KeyframesRule
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s timing function.
        ///</summary>
        public string Easing
        {
            get;
            set;
        }
    
    }
}