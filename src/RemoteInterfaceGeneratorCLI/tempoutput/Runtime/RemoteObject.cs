namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Mirror object referencing original JavaScript object.
    /// </summary>
    public sealed class RemoteObject
    {
    
        /// <summary>
        /// Object type.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// Object subtype hint. Specified for <code>object</code> type values only.
        ///</summary>
        public string Subtype
        {
            get;
            set;
        }
    
        /// <summary>
        /// Object class (constructor) name. Specified for <code>object</code> type values only.
        ///</summary>
        public string ClassName
        {
            get;
            set;
        }
    
        /// <summary>
        /// Remote object value in case of primitive values or JSON values (if it was requested).
        ///</summary>
        public object Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// Primitive value which can not be JSON-stringified does not have <code>value</code>, but gets this property.
        ///</summary>
        public UnserializableValue UnserializableValue
        {
            get;
            set;
        }
    
        /// <summary>
        /// String representation of the object.
        ///</summary>
        public string Description
        {
            get;
            set;
        }
    
        /// <summary>
        /// Unique object identifier (for non-primitive values).
        ///</summary>
        public string ObjectId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Preview containing abbreviated property values. Specified for <code>object</code> type values only.
        ///</summary>
        public ObjectPreview Preview
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public CustomPreview CustomPreview
        {
            get;
            set;
        }
    
    }
}