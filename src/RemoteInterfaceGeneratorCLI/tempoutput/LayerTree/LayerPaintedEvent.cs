namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class LayerPaintedEvent : IEvent
    {
    
        
        /// <summary>
        /// The id of the painted layer.
        /// </summary>
        
        public string LayerId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Clip rectangle.
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.Runtime.DOM.Rect Clip
        {
            get;
            set;
        }
    
    }
}