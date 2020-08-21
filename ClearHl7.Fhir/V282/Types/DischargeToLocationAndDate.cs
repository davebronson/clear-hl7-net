using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 DLD - Discharge To Location And Date.
    /// </summary>
    public class DischargeToLocationAndDate
    {
        /// <summary>
        /// DLD.1 - Discharge to Location.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0113</remarks>
        public CodedWithExceptions DischargeToLocation { get; set; }

        /// <summary>
        /// DLD.2 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }
    }
}
