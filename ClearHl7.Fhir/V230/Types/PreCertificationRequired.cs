using System;

namespace ClearHl7.Fhir.V230.Types
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

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}" : "{0}^{1}^{2}",
                                PreCertificationPatientType,
                                PreCertificationIsRequired,
                                PreCertificationWindow.HasValue ? PreCertificationWindow.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
