using System;

namespace ClearHl7.Fhir.V240.Types
{
    /// <summary>
    /// HL7 Version 2 PPN - Performing Person Time Stamp.
    /// </summary>
    public class PerformingPersonTimeStamp : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PPN.1 - Person Identifier.
        /// </summary>
        public string PersonIdentifier { get; set; }

        /// <summary>
        /// PPN.2 - Family Name.
        /// </summary>
        public FamilyName FamilyName { get; set; }

        /// <summary>
        /// PPN.3 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// PPN.4 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// PPN.5 - Suffix (e.g., JR or III).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// PPN.6 - Prefix (e.g., DR).
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// PPN.7 - Degree (e.g., MD).
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0360</remarks>
        public string Degree { get; set; }

        /// <summary>
        /// PPN.8 - Source Table.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0297</remarks>
        public string SourceTable { get; set; }

        /// <summary>
        /// PPN.9 - Assigning Authority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0363</remarks>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// PPN.10 - Name Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0200</remarks>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// PPN.11 - Identifier Check Digit.
        /// </summary>
        public string IdentifierCheckDigit { get; set; }

        /// <summary>
        /// PPN.12 - Check Digit Scheme.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0061</remarks>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// PPN.13 - Identifier Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0203</remarks>
        public string IdentifierTypeCode { get; set; }

        /// <summary>
        /// PPN.14 - Assigning Facility.
        /// </summary>
        public HierarchicDesignator AssigningFacility { get; set; }

        /// <summary>
        /// PPN.15 - Date/Time Action Performed.
        /// </summary>
        public DateTime? DateTimeActionPerformed { get; set; }

        /// <summary>
        /// PPN.16 - Name Representation Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0465</remarks>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// PPN.17 - Name Context.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0448</remarks>
        public CodedElement NameContext { get; set; }

        /// <summary>
        /// PPN.18 - Name Validity Range.
        /// </summary>
        public DateTimeRange NameValidityRange { get; set; }

        /// <summary>
        /// PPN.19 - Name Assembly Order.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0444</remarks>
        public string NameAssemblyOrder { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}&{9}&{10}&{11}&{12}&{13}&{14}&{15}&{16}&{17}&{18}" : "{0}^{1}^{2}^{3}^{4}^{5}^{6}^{7}^{8}^{9}^{10}^{11}^{12}^{13}^{14}^{15}^{16}^{17}^{18}",
                                PersonIdentifier,
                                FamilyName?.ToDelimitedString(),
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree,
                                SourceTable,
                                AssigningAuthority?.ToDelimitedString(),
                                NameTypeCode,
                                IdentifierCheckDigit,
                                CheckDigitScheme,
                                IdentifierTypeCode,
                                AssigningFacility?.ToDelimitedString(),
                                DateTimeActionPerformed.HasValue ? DateTimeActionPerformed.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                NameRepresentationCode,
                                NameContext?.ToDelimitedString(),
                                NameValidityRange?.ToDelimitedString(),
                                NameAssemblyOrder
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
