using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CCD - Charge Code and Date.
    /// </summary>
    public class ChargeCodeAndDate
    {
        /// <summary>
        /// CCD.1 - Invocation Event.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0100</remarks>
        public string InvocationEvent { get; set; }

        /// <summary>
        /// CCD.2 - Date/time.
        /// </summary>
        public DateTime Datetime { get; set; }
    }
}
