namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class AXProperty
    {
    
        /// <summary>
        /// The name of this property.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value of this property.
        ///</summary>
        public AXValue Value
        {
            get;
            set;
        }
    
    }
}