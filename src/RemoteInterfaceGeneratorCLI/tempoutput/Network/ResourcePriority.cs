namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Loading priority of a resource request.
    /// </summary>
    public sealed class ResourcePriority
    {
        private string m_value;

        private ResourcePriority(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static ResourcePriority VeryLow = new ResourcePriority("VeryLow");
    
        public static ResourcePriority Low = new ResourcePriority("Low");
    
        public static ResourcePriority Medium = new ResourcePriority("Medium");
    
        public static ResourcePriority High = new ResourcePriority("High");
    
        public static ResourcePriority VeryHigh = new ResourcePriority("VeryHigh");
    
    }
}