using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 OCD - Occurrence Code And Date.
    /// </summary>
    public class OccurrenceCodeAndDate
    {
        /// <summary>
        /// OCD.1 - Occurrence Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0350</remarks>
        public CodedWithNoExceptions OccurrenceCode { get; set; }

        /// <summary>
        /// OCD.2 - Occurrence Date.
        /// </summary>
        public DateTime? OccurrenceDate { get; set; }
    }
}
