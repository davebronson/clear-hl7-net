using System;

namespace ClearHl7.Fhir.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0397 - Sequencing.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0397</remarks>
    public enum Sequencing
    {
        /// <summary>
        /// A - Ascending.
        /// </summary>
        Ascending,
        
        /// <summary>
        /// AN - Ascending, case insensitive.
        /// </summary>
        AscendingCaseInsensitive,
        
        /// <summary>
        /// D - Descending.
        /// </summary>
        Descending,
        
        /// <summary>
        /// DN - Descending, case insensitive.
        /// </summary>
        DescendingCaseInsensitive,
        
        /// <summary>
        /// N - None.
        /// </summary>
        None
    }
}