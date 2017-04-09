namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Represents function call argument. Either remote object id <code>objectId</code>, primitive <code>value</code>, unserializable primitive value or neither of (for undefined) them should be specified.
    /// </summary>
    public sealed class CallArgument
    {
    
        /// <summary>
        /// Primitive value.
        ///</summary>
        public object Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// Primitive value which can not be JSON-stringified.
        ///</summary>
        public UnserializableValue UnserializableValue
        {
            get;
            set;
        }
    
        /// <summary>
        /// Remote object handle.
        ///</summary>
        public string ObjectId
        {
            get;
            set;
        }
    
    }
}