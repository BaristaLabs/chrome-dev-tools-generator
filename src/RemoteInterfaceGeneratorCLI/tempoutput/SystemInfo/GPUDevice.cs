namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    /// <summary>
    /// Describes a single graphics processor (GPU).
    /// </summary>
    public sealed class GPUDevice
    {
    
        /// <summary>
        /// PCI ID of the GPU vendor, if available; 0 otherwise.
        ///</summary>
        public double VendorId
        {
            get;
            set;
        }
    
        /// <summary>
        /// PCI ID of the GPU device, if available; 0 otherwise.
        ///</summary>
        public double DeviceId
        {
            get;
            set;
        }
    
        /// <summary>
        /// String description of the GPU vendor, if the PCI ID is not available.
        ///</summary>
        public string VendorString
        {
            get;
            set;
        }
    
        /// <summary>
        /// String description of the GPU device, if the PCI ID is not available.
        ///</summary>
        public string DeviceString
        {
            get;
            set;
        }
    
    }
}