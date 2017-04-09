namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    /// <summary>
    /// Serialized fragment of layer picture along with its offset within the layer.
    /// </summary>
    public sealed class PictureTile
    {
    
        /// <summary>
        /// Offset from owning layer left boundary
        ///</summary>
        public double X
        {
            get;
            set;
        }
    
        /// <summary>
        /// Offset from owning layer top boundary
        ///</summary>
        public double Y
        {
            get;
            set;
        }
    
        /// <summary>
        /// Base64-encoded snapshot data.
        ///</summary>
        public string Picture
        {
            get;
            set;
        }
    
    }
}