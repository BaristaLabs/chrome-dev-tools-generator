namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    /// <summary>
    /// advance: If the scheduler runs out of immediate work, the virtual time base may fast forward to allow the next delayed task (if any) to run; pause: The virtual time base may not advance; pauseIfNetworkFetchesPending: The virtual time base may not advance if there are any pending resource fetches.
    /// </summary>
    public sealed class VirtualTimePolicy
    {
        private string m_value;

        private VirtualTimePolicy(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static VirtualTimePolicy Advance = new VirtualTimePolicy("advance");
    
        public static VirtualTimePolicy Pause = new VirtualTimePolicy("pause");
    
        public static VirtualTimePolicy PauseIfNetworkFetchesPending = new VirtualTimePolicy("pauseIfNetworkFetchesPending");
    
    }
}