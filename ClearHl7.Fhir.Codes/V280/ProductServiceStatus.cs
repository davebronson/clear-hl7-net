using System;

namespace ClearHl7.Fhir.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0559 - Product/Service Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0559</remarks>
    public enum ProductServiceStatus
    {
        /// <summary>
        /// D - Denied.
        /// </summary>
        Denied,
        
        /// <summary>
        /// P - Processed.
        /// </summary>
        Processed,
        
        /// <summary>
        /// R - Rejected.
        /// </summary>
        Rejected
    }
}