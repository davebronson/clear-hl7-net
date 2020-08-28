using System;

namespace ClearHl7.Fhir.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0334 - Disabled Person Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0334</remarks>
    public enum DisabledPersonCode
    {
        /// <summary>
        /// AP - Associated party.
        /// </summary>
        AssociatedParty,
        
        /// <summary>
        /// GT - Guarantor.
        /// </summary>
        Guarantor,
        
        /// <summary>
        /// IN - Insured.
        /// </summary>
        Insured,
        
        /// <summary>
        /// PT - Patient.
        /// </summary>
        Patient
    }
}