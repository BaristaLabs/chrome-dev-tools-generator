namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    /// <summary>
    /// Provides information about the GPU(s) on the system.
    /// </summary>
    public sealed class GPUInfo
    {
    
        /// <summary>
        /// The graphics devices on the system. Element 0 is the primary GPU.
        ///</summary>
        public GPUDevice[] Devices
        {
            get;
            set;
        }
    
        /// <summary>
        /// An optional dictionary of additional GPU related attributes.
        ///</summary>
        public object AuxAttributes
        {
            get;
            set;
        }
    
        /// <summary>
        /// An optional dictionary of graphics features and their status.
        ///</summary>
        public object FeatureStatus
        {
            get;
            set;
        }
    
        /// <summary>
        /// An optional array of GPU driver bug workarounds.
        ///</summary>
        public string[] DriverBugWorkarounds
        {
            get;
            set;
        }
    
    }
}