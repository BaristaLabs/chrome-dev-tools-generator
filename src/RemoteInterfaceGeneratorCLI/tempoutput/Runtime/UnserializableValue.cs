namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Primitive value which cannot be JSON-stringified.
    /// </summary>
    public sealed class UnserializableValue
    {
        private string m_value;

        private UnserializableValue(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static UnserializableValue Infinity = new UnserializableValue("Infinity");
    
        public static UnserializableValue NaN = new UnserializableValue("NaN");
    
        public static UnserializableValue NegativeInfinity = new UnserializableValue("-Infinity");
    
        public static UnserializableValue Negative0 = new UnserializableValue("-0");
    
    }
}