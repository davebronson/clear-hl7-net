using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 SAD - Street Address.
    /// </summary>
    public class StreetAddress
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SAD.1 - Street or Mailing Address.
        /// </summary>
        public string StreetOrMailingAddress { get; set; }

        /// <summary>
        /// SAD.2 - Street Name.
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// SAD.3 - Dwelling Number.
        /// </summary>
        public string DwellingNumber { get; set; }
    }
}
