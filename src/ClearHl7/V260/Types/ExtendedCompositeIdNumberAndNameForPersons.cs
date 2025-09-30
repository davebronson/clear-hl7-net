using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 XCN - Extended Composite Id Number And Name For Persons.
    /// </summary>
    public class ExtendedCompositeIdNumberAndNameForPersons : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedCompositeIdNumberAndNameForPersons"/> class.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedCompositeIdNumberAndNameForPersons"/> class.
        /// </summary>
        /// <param name="personIdentifier">XCN.1 - Person Identifier.</param>
        public ExtendedCompositeIdNumberAndNameForPersons(string personIdentifier)
        {
            PersonIdentifier = personIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedCompositeIdNumberAndNameForPersons"/> class.
        /// </summary>
        /// <param name="personIdentifier">XCN.1 - Person Identifier.</param>
        /// <param name="familyName">XCN.2 - Family Name.</param>
        /// <param name="givenName">XCN.3 - Given Name.</param>
        public ExtendedCompositeIdNumberAndNameForPersons(string personIdentifier, FamilyName familyName, string givenName)
        {
            PersonIdentifier = personIdentifier;
            FamilyName = familyName;
            GivenName = givenName;
        }

        /// <inheritdoc/>
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
        /// <para>Suggested: 0360 Degree/License/Certificate</para>
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// XCN.8 - Source Table.
        /// <para>Suggested: 0297 Source Table</para>
        /// </summary>
        public string SourceTable { get; set; }

        /// <summary>
        /// XCN.9 - Assigning Authority.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V260.CodeAssigningAuthority</para>
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// XCN.10 - Name Type Code.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V260.CodeNameType</para>
        /// </summary>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// XCN.11 - Identifier Check Digit.
        /// </summary>
        public string IdentifierCheckDigit { get; set; }

        /// <summary>
        /// XCN.12 - Check Digit Scheme.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V260.CodeCheckDigitScheme</para>
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// XCN.13 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V260.CodeIdentifierType</para>
        /// </summary>
        public string IdentifierTypeCode { get; set; }

        /// <summary>
        /// XCN.14 - Assigning Facility.
        /// </summary>
        public HierarchicDesignator AssigningFacility { get; set; }

        /// <summary>
        /// XCN.15 - Name Representation Code.
        /// <para>Suggested: 0465 Name/Address Representation -&gt; ClearHl7.Codes.V260.CodeNameAddressRepresentation</para>
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
        /// <para>Suggested: 0444 Name Assembly Order -&gt; ClearHl7.Codes.V260.CodeNameAssemblyOrder</para>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            PersonIdentifier = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            FamilyName = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<FamilyName>(segments[1], true, seps) : null;
            GivenName = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            SecondAndFurtherGivenNamesOrInitialsThereof = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            Suffix = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            Prefix = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Degree = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            SourceTable = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            AssigningAuthority = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[8], true, seps) : null;
            NameTypeCode = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            IdentifierCheckDigit = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            CheckDigitScheme = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            IdentifierTypeCode = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            AssigningFacility = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[13], true, seps) : null;
            NameRepresentationCode = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            NameContext = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[15], true, seps) : null;
            NameValidityRange = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<DateTimeRange>(segments[16], true, seps) : null;
            NameAssemblyOrder = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            EffectiveDate = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDateTime() : null;
            ExpirationDate = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
            ProfessionalSuffix = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            AssigningJurisdiction = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[21], true, seps) : null;
            AssigningAgencyOrDepartment = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[22], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 23, separator),
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
                                NameRepresentationCode,
                                NameContext?.ToDelimitedString(),
                                NameValidityRange?.ToDelimitedString(),
                                NameAssemblyOrder,
                                EffectiveDate?.ToHl7DateTimeString(typeof(ExtendedCompositeIdNumberAndNameForPersons), nameof(EffectiveDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ExpirationDate?.ToHl7DateTimeString(typeof(ExtendedCompositeIdNumberAndNameForPersons), nameof(ExpirationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProfessionalSuffix,
                                AssigningJurisdiction?.ToDelimitedString(),
                                AssigningAgencyOrDepartment?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
