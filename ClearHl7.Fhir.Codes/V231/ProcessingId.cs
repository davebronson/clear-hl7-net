using System;

namespace ClearHl7.Fhir.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0103 - Processing ID.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0103</remarks>
    public enum ProcessingId
    {
        /// <summary>
        /// D - Debugging.
        /// </summary>
        Debugging,
        
        /// <summary>
        /// P - Production.
        /// </summary>
        Production,
        
        /// <summary>
        /// T - Training.
        /// </summary>
        Training
    }
}