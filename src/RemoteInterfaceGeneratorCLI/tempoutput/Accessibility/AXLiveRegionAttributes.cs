namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// Attributes which apply to nodes in live regions.
    /// </summary>
    public sealed class AXLiveRegionAttributes
    {
        private string m_value;

        private AXLiveRegionAttributes(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static AXLiveRegionAttributes Live = new AXLiveRegionAttributes("live");
    
        public static AXLiveRegionAttributes Atomic = new AXLiveRegionAttributes("atomic");
    
        public static AXLiveRegionAttributes Relevant = new AXLiveRegionAttributes("relevant");
    
        public static AXLiveRegionAttributes Busy = new AXLiveRegionAttributes("busy");
    
        public static AXLiveRegionAttributes Root = new AXLiveRegionAttributes("root");
    
    }
}