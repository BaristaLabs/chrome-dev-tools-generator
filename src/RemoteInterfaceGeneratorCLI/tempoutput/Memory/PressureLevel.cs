namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    /// <summary>
    /// Memory pressure level.
    /// </summary>
    public sealed class PressureLevel
    {
        private string m_value;

        private PressureLevel(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static PressureLevel Moderate = new PressureLevel("moderate");
    
        public static PressureLevel Critical = new PressureLevel("critical");
    
    }
}