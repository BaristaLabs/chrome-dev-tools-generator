namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    /// <summary>
    /// Screen orientation.
    /// </summary>
    public sealed class ScreenOrientation
    {
    
        /// <summary>
        /// Orientation type.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// Orientation angle.
        ///</summary>
        public long Angle
        {
            get;
            set;
        }
    
    }
}