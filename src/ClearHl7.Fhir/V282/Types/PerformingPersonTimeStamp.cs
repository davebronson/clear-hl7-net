using System;
using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V282.Types
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
        public string Degree { get; set; }

        /// <summary>
        /// PPN.8 - Source Table.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0297</remarks>
        public CodedWithExceptions SourceTable { get; set; }

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
        public CodedWithExceptions NameContext { get; set; }

        /// <summary>
        /// PPN.18 - Name Validity Range.
        /// </summary>
        public string NameValidityRange { get; set; }

        /// <summary>
        /// PPN.19 - Name Assembly Order.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0444</remarks>
        public string NameAssemblyOrder { get; set; }

        /// <summary>
        /// PPN.20 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// PPN.21 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// PPN.22 - Professional Suffix.
        /// </summary>
        public string ProfessionalSuffix { get; set; }

        /// <summary>
        /// PPN.23 - Assigning Jurisdiction.
        /// </summary>
        public CodedWithExceptions AssigningJurisdiction { get; set; }

        /// <summary>
        /// PPN.24 - Assigning Agency or Department.
        /// </summary>
        public CodedWithExceptions AssigningAgencyOrDepartment { get; set; }

        /// <summary>
        /// PPN.25 - Security Check.
        /// </summary>
        public string SecurityCheck { get; set; }

        /// <summary>
        /// PPN.26 - Security Check Scheme.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0904</remarks>
        public string SecurityCheckScheme { get; set; }

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
                                StringHelper.StringFormatSequence(0, 26, separator),
                                PersonIdentifier,
                                FamilyName?.ToDelimitedString(),
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree,
                                SourceTable?.ToDelimitedString(),
                                AssigningAuthority?.ToDelimitedString(),
                                NameTypeCode,
                                IdentifierCheckDigit,
                                CheckDigitScheme,
                                IdentifierTypeCode,
                                AssigningFacility?.ToDelimitedString(),
                                DateTimeActionPerformed.HasValue ? DateTimeActionPerformed.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                NameRepresentationCode,
                                NameContext?.ToDelimitedString(),
                                NameValidityRange,
                                NameAssemblyOrder,
                                EffectiveDate.HasValue ? EffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProfessionalSuffix,
                                AssigningJurisdiction?.ToDelimitedString(),
                                AssigningAgencyOrDepartment?.ToDelimitedString(),
                                SecurityCheck,
                                SecurityCheckScheme
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
