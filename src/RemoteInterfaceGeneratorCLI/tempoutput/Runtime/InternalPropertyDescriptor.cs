namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Object internal property descriptor. This property isn't normally visible in JavaScript code.
    /// </summary>
    public sealed class InternalPropertyDescriptor
    {
    
        /// <summary>
        /// Conventional property name.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value associated with the property.
        ///</summary>
        public RemoteObject Value
        {
            get;
            set;
        }
    
    }
}