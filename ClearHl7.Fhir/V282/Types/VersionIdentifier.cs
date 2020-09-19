using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 VID - Version Identifier.
    /// </summary>
    public class VersionIdentifier : IType
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}" : "{0}^{1}^{2}",
                                VersionId,
                                InternationalizationCode?.ToDelimitedString(),
                                InternationalVersionId?.ToDelimitedString()
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
