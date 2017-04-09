namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Security details about a request.
    /// </summary>
    public sealed class SecurityDetails
    {
    
        /// <summary>
        /// Protocol name (e.g. "TLS 1.2" or "QUIC").
        ///</summary>
        public string Protocol
        {
            get;
            set;
        }
    
        /// <summary>
        /// Key Exchange used by the connection, or the empty string if not applicable.
        ///</summary>
        public string KeyExchange
        {
            get;
            set;
        }
    
        /// <summary>
        /// (EC)DH group used by the connection, if applicable.
        ///</summary>
        public string KeyExchangeGroup
        {
            get;
            set;
        }
    
        /// <summary>
        /// Cipher name.
        ///</summary>
        public string Cipher
        {
            get;
            set;
        }
    
        /// <summary>
        /// TLS MAC. Note that AEAD ciphers do not have separate MACs.
        ///</summary>
        public string Mac
        {
            get;
            set;
        }
    
        /// <summary>
        /// Certificate ID value.
        ///</summary>
        public long CertificateId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Certificate subject name.
        ///</summary>
        public string SubjectName
        {
            get;
            set;
        }
    
        /// <summary>
        /// Subject Alternative Name (SAN) DNS names and IP addresses.
        ///</summary>
        public string[] SanList
        {
            get;
            set;
        }
    
        /// <summary>
        /// Name of the issuing CA.
        ///</summary>
        public string Issuer
        {
            get;
            set;
        }
    
        /// <summary>
        /// Certificate valid from date.
        ///</summary>
        public double ValidFrom
        {
            get;
            set;
        }
    
        /// <summary>
        /// Certificate valid to (expiration) date
        ///</summary>
        public double ValidTo
        {
            get;
            set;
        }
    
        /// <summary>
        /// List of signed certificate timestamps (SCTs).
        ///</summary>
        public SignedCertificateTimestamp[] SignedCertificateTimestampList
        {
            get;
            set;
        }
    
    }
}