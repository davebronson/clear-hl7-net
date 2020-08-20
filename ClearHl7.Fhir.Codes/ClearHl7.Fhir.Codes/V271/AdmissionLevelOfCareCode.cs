using System;

namespace ClearHl7.Fhir.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0432 - Admission Level Of Care Code.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0432</remarks>
    public enum AdmissionLevelOfCareCode
    {
        /// <summary>
        /// AC - Acute.
        /// </summary>
        Acute,
        
        /// <summary>
        /// CH - Chronic.
        /// </summary>
        Chronic,
        
        /// <summary>
        /// CO - Comatose.
        /// </summary>
        Comatose,
        
        /// <summary>
        /// CR - Critical.
        /// </summary>
        Critical,
        
        /// <summary>
        /// IM - Improved.
        /// </summary>
        Improved,
        
        /// <summary>
        /// MO - Moribund.
        /// </summary>
        Moribund
    }
}