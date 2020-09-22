using System;

namespace ClearHl7.Fhir.V271.Types
{
    /// <summary>
    /// HL7 Version 2 ICD - Insurance Certification Definition.
    /// </summary>
    public class InsuranceCertificationDefinition : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// ICD.1 - Certification Patient Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0150</remarks>
        public CodedWithExceptions CertificationPatientType { get; set; }

        /// <summary>
        /// ICD.2 - Certification Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string CertificationRequired { get; set; }

        /// <summary>
        /// ICD.3 - Date/Time Certification Required.
        /// </summary>
        public DateTime? DateTimeCertificationRequired { get; set; }

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
                                CertificationPatientType?.ToDelimitedString(),
                                CertificationRequired,
                                DateTimeCertificationRequired.HasValue ? DateTimeCertificationRequired.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
