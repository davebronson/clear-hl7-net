using System;
using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V231.Types
{
    /// <summary>
    /// HL7 Version 2 PCF - Pre-Certification Required.
    /// </summary>
    public class PreCertificationRequired : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PCF.1 - Pre-certification Patient Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0150</remarks>
        public string PreCertificationPatientType { get; set; }

        /// <summary>
        /// PCF.2 - Pre-Certification Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PreCertificationIsRequired { get; set; }

        /// <summary>
        /// PCF.3 - Pre-certification Window.
        /// </summary>
        public DateTime? PreCertificationWindow { get; set; }

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
                                PreCertificationPatientType,
                                PreCertificationIsRequired,
                                PreCertificationWindow.HasValue ? PreCertificationWindow.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
