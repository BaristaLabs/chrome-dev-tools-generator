namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
    /// </summary>
    public sealed class SetCookieCommand : ICommand<SetCookieCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setCookie";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The request-URI to associate with the setting of the cookie. This value can affect the default domain and path values of the created cookie.
        /// </summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The name of the cookie.
        /// </summary>
        
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The value of the cookie.
        /// </summary>
        
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If omitted, the cookie becomes a host-only cookie.
        /// </summary>
        
        [JsonProperty("domain")]
        public string Domain
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Defaults to the path portion of the url parameter.
        /// </summary>
        
        [JsonProperty("path")]
        public string Path
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Defaults ot false.
        /// </summary>
        
        [JsonProperty("secure")]
        public bool Secure
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Defaults to false.
        /// </summary>
        
        [JsonProperty("httpOnly")]
        public bool HttpOnly
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Defaults to browser default behavior.
        /// </summary>
        
        [JsonProperty("sameSite")]
        public CookieSameSite SameSite
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If omitted, the cookie becomes a session cookie.
        /// </summary>
        
        [JsonProperty("expirationDate")]
        public double ExpirationDate
        {
            get;
            set;
        }
    
    }

    public sealed class SetCookieCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// True if successfully set cookie.
        ///</summary>
        
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }
    
    }
}