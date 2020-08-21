using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 PT - Processing Type.
    /// </summary>
    public class ProcessingType
    {
        /// <summary>
        /// PT.1 - Processing ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0103</remarks>
        public string ProcessingId { get; set; }

        /// <summary>
        /// PT.2 - Processing Mode.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0207</remarks>
        public string ProcessingMode { get; set; }
    }
}
