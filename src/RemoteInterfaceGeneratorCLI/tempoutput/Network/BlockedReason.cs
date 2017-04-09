namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// The reason why request was blocked.
    /// </summary>
    public sealed class BlockedReason
    {
        private string m_value;

        private BlockedReason(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static BlockedReason Csp = new BlockedReason("csp");
    
        public static BlockedReason MixedContent = new BlockedReason("mixed-content");
    
        public static BlockedReason Origin = new BlockedReason("origin");
    
        public static BlockedReason Inspector = new BlockedReason("inspector");
    
        public static BlockedReason SubresourceFilter = new BlockedReason("subresource-filter");
    
        public static BlockedReason Other = new BlockedReason("other");
    
    }
}