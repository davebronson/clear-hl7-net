using System;

namespace ClearHl7.Fhir.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0500 - Consent Disclosure Level.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0500</remarks>
    public enum ConsentDisclosureLevel
    {
        /// <summary>
        /// F - Full Disclosure.
        /// </summary>
        FullDisclosure,
        
        /// <summary>
        /// N - No Disclosure.
        /// </summary>
        NoDisclosure,
        
        /// <summary>
        /// P - Partial Disclosure.
        /// </summary>
        PartialDisclosure
    }
}