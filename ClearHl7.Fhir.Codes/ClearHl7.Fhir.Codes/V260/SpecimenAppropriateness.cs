using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0492 - Specimen Appropriateness.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0492</remarks>
    public enum SpecimenAppropriateness
    {
        /// <summary>
        /// ?? - Inappropriate due to ....
        /// </summary>
        InappropriateDueTo,
        
        /// <summary>
        /// A - Appropriate.
        /// </summary>
        Appropriate,
        
        /// <summary>
        /// I - Inappropriate.
        /// </summary>
        Inappropriate,
        
        /// <summary>
        /// P - Preferred.
        /// </summary>
        Preferred
    }
}