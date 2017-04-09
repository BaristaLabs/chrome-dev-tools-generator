namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Details of a signed certificate timestamp (SCT).
    /// </summary>
    public sealed class SignedCertificateTimestamp
    {
    
        /// <summary>
        /// Validation status.
        ///</summary>
        public string Status
        {
            get;
            set;
        }
    
        /// <summary>
        /// Origin.
        ///</summary>
        public string Origin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Log name / description.
        ///</summary>
        public string LogDescription
        {
            get;
            set;
        }
    
        /// <summary>
        /// Log ID.
        ///</summary>
        public string LogId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Issuance date.
        ///</summary>
        public double Timestamp
        {
            get;
            set;
        }
    
        /// <summary>
        /// Hash algorithm.
        ///</summary>
        public string HashAlgorithm
        {
            get;
            set;
        }
    
        /// <summary>
        /// Signature algorithm.
        ///</summary>
        public string SignatureAlgorithm
        {
            get;
            set;
        }
    
        /// <summary>
        /// Signature data.
        ///</summary>
        public string SignatureData
        {
            get;
            set;
        }
    
    }
}