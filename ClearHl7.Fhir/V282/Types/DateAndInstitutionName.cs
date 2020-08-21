using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 DIN - Date And Institution Name.
    /// </summary>
    public class DateAndInstitutionName
    {
        /// <summary>
        /// DIN.1 - Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// DIN.2 - Institution Name.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0531</remarks>
        public CodedWithExceptions InstitutionName { get; set; }
    }
}
