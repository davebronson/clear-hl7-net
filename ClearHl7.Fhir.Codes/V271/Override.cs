using System;

namespace ClearHl7.Fhir.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0268 - Override.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0268</remarks>
    public enum Override
    {
        /// <summary>
        /// A - Override allowed.
        /// </summary>
        OverrideAllowed,
        
        /// <summary>
        /// R - Override required.
        /// </summary>
        OverrideRequired,
        
        /// <summary>
        /// X - Override not allowed.
        /// </summary>
        OverrideNotAllowed
    }
}