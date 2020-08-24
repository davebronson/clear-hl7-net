using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 VID - Version Identifier.
    /// </summary>
    public class VersionIdentifier
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// VID.1 - Version ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0104</remarks>
        public string VersionId { get; set; }

        /// <summary>
        /// VID.2 - Internationalization Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0399</remarks>
        public CodedWithExceptions InternationalizationCode { get; set; }

        /// <summary>
        /// VID.3 - International Version ID.
        /// </summary>
        public CodedWithExceptions InternationalVersionId { get; set; }
    }
}
