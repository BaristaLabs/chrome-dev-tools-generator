namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Loading priority of a resource request.
    /// </summary>
    public sealed class ConnectionType
    {
        private string m_value;

        private ConnectionType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static ConnectionType None = new ConnectionType("none");
    
        public static ConnectionType Cellular2g = new ConnectionType("cellular2g");
    
        public static ConnectionType Cellular3g = new ConnectionType("cellular3g");
    
        public static ConnectionType Cellular4g = new ConnectionType("cellular4g");
    
        public static ConnectionType Bluetooth = new ConnectionType("bluetooth");
    
        public static ConnectionType Ethernet = new ConnectionType("ethernet");
    
        public static ConnectionType Wifi = new ConnectionType("wifi");
    
        public static ConnectionType Wimax = new ConnectionType("wimax");
    
        public static ConnectionType Other = new ConnectionType("other");
    
    }
}