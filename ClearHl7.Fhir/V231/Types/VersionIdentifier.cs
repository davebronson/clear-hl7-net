﻿using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V231.Types
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
        /// <remarks>https://www.iso.org/iso-3166-country-codes.html</remarks>
        public CodedElement InternationalizationCode { get; set; }

        /// <summary>
        /// VID.3 - International Version ID.
        /// </summary>
        public CodedElement InternationalVersionId { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                VersionId,
                                InternationalizationCode?.ToDelimitedString(),
                                InternationalVersionId?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
