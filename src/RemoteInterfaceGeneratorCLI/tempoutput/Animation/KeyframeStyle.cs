namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    /// <summary>
    /// Keyframe Style
    /// </summary>
    public sealed class KeyframeStyle
    {
    
        /// <summary>
        /// Keyframe's time offset.
        ///</summary>
        public string Offset
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