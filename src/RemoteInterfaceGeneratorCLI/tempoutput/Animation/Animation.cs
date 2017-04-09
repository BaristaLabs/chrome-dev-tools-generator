namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    /// <summary>
    /// Animation instance.
    /// </summary>
    public sealed class Animation
    {
    
        /// <summary>
        /// <code>Animation</code>'s id.
        ///</summary>
        public string Id
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s name.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s internal paused state.
        ///</summary>
        public bool PausedState
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s play state.
        ///</summary>
        public string PlayState
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s playback rate.
        ///</summary>
        public double PlaybackRate
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s start time.
        ///</summary>
        public double StartTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s current time.
        ///</summary>
        public double CurrentTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s source animation node.
        ///</summary>
        public AnimationEffect Source
        {
            get;
            set;
        }
    
        /// <summary>
        /// Animation type of <code>Animation</code>.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// A unique ID for <code>Animation</code> representing the sources that triggered this CSS animation/transition.
        ///</summary>
        public string CssId
        {
            get;
            set;
        }
    
    }
}