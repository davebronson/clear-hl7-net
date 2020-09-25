using System;

namespace ClearHl7.Fhir.V260.Types
{
    /// <summary>
    /// HL7 Version 2 XPN - Extended Person Name.
    /// </summary>
    public class ExtendedPersonName : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// XPN.1 - Family Name.
        /// </summary>
        public FamilyName FamilyName { get; set; }

        /// <summary>
        /// XPN.2 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// XPN.3 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// XPN.4 - Suffix (e.g., JR or III).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// XPN.5 - Prefix (e.g., DR).
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// XPN.6 - Degree (e.g., MD).
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0360</remarks>
        public string Degree { get; set; }

        /// <summary>
        /// XPN.7 - Name Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0200</remarks>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// XPN.8 - Name Representation Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0465</remarks>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// XPN.9 - Name Context.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0448</remarks>
        public CodedWithExceptions NameContext { get; set; }

        /// <summary>
        /// XPN.10 - Name Validity Range.
        /// </summary>
        public DateTimeRange NameValidityRange { get; set; }

        /// <summary>
        /// XPN.11 - Name Assembly Order.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0444</remarks>
        public string NameAssemblyOrder { get; set; }

        /// <summary>
        /// XPN.12 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// XPN.13 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// XPN.14 - Professional Suffix.
        /// </summary>
        public string ProfessionalSuffix { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}&{9}&{10}&{11}&{12}&{13}" : "{0}^{1}^{2}^{3}^{4}^{5}^{6}^{7}^{8}^{9}^{10}^{11}^{12}^{13}",
                                FamilyName?.ToDelimitedString(),
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree,
                                NameTypeCode,
                                NameRepresentationCode,
                                NameContext?.ToDelimitedString(),
                                NameValidityRange?.ToDelimitedString(),
                                NameAssemblyOrder,
                                EffectiveDate.HasValue ? EffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProfessionalSuffix
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
