namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class LayerTreeDidChangeEvent : IEvent
    {
    
        
        /// <summary>
        /// Layer tree, absent if not in the comspositing mode.
        /// </summary>
        
        public Layer[] Layers
        {
            get;
            set;
        }
    
    }
}