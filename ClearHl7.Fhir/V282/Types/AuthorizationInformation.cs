using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 AUI - Authorization Information.
    /// </summary>
    public class AuthorizationInformation
    {
        /// <summary>
        /// AUI.1 - Authorization Number.
        /// </summary>
        public string AuthorizationNumber { get; set; }

        /// <summary>
        /// AUI.2 - Date.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// AUI.3 - Source.
        /// </summary>
        public string Source { get; set; }
    }
}
