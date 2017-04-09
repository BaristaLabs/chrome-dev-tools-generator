namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class AddDatabaseEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the database
        /// </summary>
        
        public Database Database
        {
            get;
            set;
        }
    
    }
}