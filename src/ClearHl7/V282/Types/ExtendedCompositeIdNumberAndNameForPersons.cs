using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V282.Types
{
    /// <summary>
    /// HL7 Version 2 XCN - Extended Composite Id Number And Name For Persons.
    /// </summary>
    public class ExtendedCompositeIdNumberAndNameForPersons : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// XCN.1 - Person Identifier.
        /// </summary>
        public string PersonIdentifier { get; set; }

        /// <summary>
        /// XCN.2 - Family Name.
        /// </summary>
        public FamilyName FamilyName { get; set; }

        /// <summary>
        /// XCN.3 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// XCN.4 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// XCN.5 - Suffix (e.g., JR or III).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// XCN.6 - Prefix (e.g., DR).
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// XCN.7 - Degree (e.g., MD).
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// XCN.8 - Source Table.
        /// <para>Suggested: 0297 Source Table</para>
        /// </summary>
        public CodedWithExceptions SourceTable { get; set; }

        /// <summary>
        /// XCN.9 - Assigning Authority.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V282.CodeAssigningAuthority</para>
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// XCN.10 - Name Type Code.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V282.CodeNameType</para>
        /// </summary>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// XCN.11 - Identifier Check Digit.
        /// </summary>
        public string IdentifierCheckDigit { get; set; }

        /// <summary>
        /// XCN.12 - Check Digit Scheme.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V282.CodeCheckDigitScheme</para>
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// XCN.13 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V282.CodeIdentifierType</para>
        /// </summary>
        public string IdentifierTypeCode { get; set; }

        /// <summary>
        /// XCN.14 - Assigning Facility.
        /// </summary>
        public HierarchicDesignator AssigningFacility { get; set; }

        /// <summary>
        /// XCN.15 - Name Representation Code.
        /// <para>Suggested: 0465 Name/Address Representation -&gt; ClearHl7.Codes.V282.CodeNameAddressRepresentation</para>
        /// </summary>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// XCN.16 - Name Context.
        /// <para>Suggested: 0448 Name Context</para>
        /// </summary>
        public CodedWithExceptions NameContext { get; set; }

        /// <summary>
        /// XCN.17 - Name Validity Range.
        /// </summary>
        public DateTimeRange NameValidityRange { get; set; }

        /// <summary>
        /// XCN.18 - Name Assembly Order.
        /// <para>Suggested: 0444 Name Assembly Order -&gt; ClearHl7.Codes.V282.CodeNameAssemblyOrder</para>
        /// </summary>
        public string NameAssemblyOrder { get; set; }

        /// <summary>
        /// XCN.19 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// XCN.20 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// XCN.21 - Professional Suffix.
        /// </summary>
        public string ProfessionalSuffix { get; set; }

        /// <summary>
        /// XCN.22 - Assigning Jurisdiction.
        /// </summary>
        public CodedWithExceptions AssigningJurisdiction { get; set; }

        /// <summary>
        /// XCN.23 - Assigning Agency or Department.
        /// </summary>
        public CodedWithExceptions AssigningAgencyOrDepartment { get; set; }

        /// <summary>
        /// XCN.24 - Security Check.
        /// </summary>
        public string SecurityCheck { get; set; }

        /// <summary>
        /// XCN.25 - Security Check Scheme.
        /// <para>Suggested: 0904 Security Check Scheme -&gt; ClearHl7.Codes.V282.CodeSecurityCheckScheme</para>
        /// </summary>
        public string SecurityCheckScheme { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            PersonIdentifier = segments.ElementAtOrDefault(0);
            FamilyName = segments.Length > 1 ? TypeHelper.Deserialize<FamilyName>(segments.ElementAtOrDefault(1), true) : null;
            GivenName = segments.ElementAtOrDefault(2);
            SecondAndFurtherGivenNamesOrInitialsThereof = segments.ElementAtOrDefault(3);
            Suffix = segments.ElementAtOrDefault(4);
            Prefix = segments.ElementAtOrDefault(5);
            Degree = segments.ElementAtOrDefault(6);
            SourceTable = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), true) : null;
            AssigningAuthority = segments.Length > 8 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(8), true) : null;
            NameTypeCode = segments.ElementAtOrDefault(9);
            IdentifierCheckDigit = segments.ElementAtOrDefault(10);
            CheckDigitScheme = segments.ElementAtOrDefault(11);
            IdentifierTypeCode = segments.ElementAtOrDefault(12);
            AssigningFacility = segments.Length > 13 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(13), true) : null;
            NameRepresentationCode = segments.ElementAtOrDefault(14);
            NameContext = segments.Length > 15 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(15), true) : null;
            NameValidityRange = segments.Length > 16 ? TypeHelper.Deserialize<DateTimeRange>(segments.ElementAtOrDefault(16), true) : null;
            NameAssemblyOrder = segments.ElementAtOrDefault(17);
            EffectiveDate = segments.ElementAtOrDefault(18)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ExpirationDate = segments.ElementAtOrDefault(19)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ProfessionalSuffix = segments.ElementAtOrDefault(20);
            AssigningJurisdiction = segments.Length > 21 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(21), true) : null;
            AssigningAgencyOrDepartment = segments.Length > 22 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(22), true) : null;
            SecurityCheck = segments.ElementAtOrDefault(23);
            SecurityCheckScheme = segments.ElementAtOrDefault(24);
        }

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
                                StringHelper.StringFormatSequence(0, 25, separator),
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
                                NameRepresentationCode,
                                NameContext?.ToDelimitedString(),
                                NameValidityRange?.ToDelimitedString(),
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
