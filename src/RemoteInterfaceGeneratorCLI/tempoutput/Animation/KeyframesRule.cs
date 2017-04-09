namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    /// <summary>
    /// Keyframes Rule
    /// </summary>
    public sealed class KeyframesRule
    {
    
        /// <summary>
        /// CSS keyframed animation's name.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// List of animation keyframes.
        ///</summary>
        public KeyframeStyle[] Keyframes
        {
            get;
            set;
        }
    
    }
}