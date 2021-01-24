using System;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
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
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                CertificationPatientType?.ToDelimitedString(),
                                CertificationRequired,
                                DateTimeCertificationRequired.HasValue ? DateTimeCertificationRequired.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
