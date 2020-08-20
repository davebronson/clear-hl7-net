using System;

namespace ClearHl7.Fhir.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0918 - PCA Type.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0918</remarks>
    public enum PcaType
    {
        /// <summary>
        /// C - Continuous.
        /// </summary>
        Continuous,
        
        /// <summary>
        /// P - PCA Only.
        /// </summary>
        PcaOnly,
        
        /// <summary>
        /// PC - PCA + Continuous.
        /// </summary>
        PcaContinuous
    }
}