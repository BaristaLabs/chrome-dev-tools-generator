namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    /// <summary>
    /// The security level of a page or resource.
    /// </summary>
    public sealed class SecurityState
    {
        private string m_value;

        private SecurityState(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static SecurityState Unknown = new SecurityState("unknown");
    
        public static SecurityState Neutral = new SecurityState("neutral");
    
        public static SecurityState Insecure = new SecurityState("insecure");
    
        public static SecurityState Warning = new SecurityState("warning");
    
        public static SecurityState Secure = new SecurityState("secure");
    
        public static SecurityState Info = new SecurityState("info");
    
    }
}