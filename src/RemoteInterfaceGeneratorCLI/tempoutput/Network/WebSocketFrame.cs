namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// WebSocket frame data.
    /// </summary>
    public sealed class WebSocketFrame
    {
    
        /// <summary>
        /// WebSocket frame opcode.
        ///</summary>
        public double Opcode
        {
            get;
            set;
        }
    
        /// <summary>
        /// WebSocke frame mask.
        ///</summary>
        public bool Mask
        {
            get;
            set;
        }
    
        /// <summary>
        /// WebSocke frame payload data.
        ///</summary>
        public string PayloadData
        {
            get;
            set;
        }
    
    }
}