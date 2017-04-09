namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// States which apply to every AX node.
    /// </summary>
    public sealed class AXGlobalStates
    {
        private string m_value;

        private AXGlobalStates(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static AXGlobalStates Disabled = new AXGlobalStates("disabled");
    
        public static AXGlobalStates Hidden = new AXGlobalStates("hidden");
    
        public static AXGlobalStates HiddenRoot = new AXGlobalStates("hiddenRoot");
    
        public static AXGlobalStates Invalid = new AXGlobalStates("invalid");
    
    }
}