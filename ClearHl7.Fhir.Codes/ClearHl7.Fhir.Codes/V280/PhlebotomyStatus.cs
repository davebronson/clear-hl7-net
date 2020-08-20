using System;

namespace ClearHl7.Fhir.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0926 - Phlebotomy Status.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0926</remarks>
    public enum PhlebotomyStatus
    {
        /// <summary>
        /// NDR - Not Drawn.
        /// </summary>
        NotDrawn,
        
        /// <summary>
        /// SUC - Successful.
        /// </summary>
        Successful,
        
        /// <summary>
        /// UL5 - Unsuccessful Less than 50 ml drawn.
        /// </summary>
        UnsuccessfulLessThan50MlDrawn
    }
}