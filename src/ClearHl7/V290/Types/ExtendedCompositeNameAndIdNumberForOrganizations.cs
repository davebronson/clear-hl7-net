using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 XON - Extended Composite Name And Identification Number For Organizations.
    /// </summary>
    public class ExtendedCompositeNameAndIdNumberForOrganizations : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedCompositeNameAndIdNumberForOrganizations"/> class.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedCompositeNameAndIdNumberForOrganizations"/> class.
        /// </summary>
        /// <param name="organizationName">XON.1 - Organization Name.</param>
        public ExtendedCompositeNameAndIdNumberForOrganizations(string organizationName)
        {
            OrganizationName = organizationName;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// XON.1 - Organization Name.
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// XON.2 - Organization Name Type Code.
        /// <para>Suggested: 0204 Organizational Name Type -&gt; ClearHl7.Codes.V290.CodeOrganizationalNameType</para>
        /// </summary>
        public CodedWithExceptions OrganizationNameTypeCode { get; set; }

        /// <summary>
        /// XON.3 - ID Number.
        /// </summary>
        public decimal? IdNumber { get; set; }

        /// <summary>
        /// XON.4 - Identifier Check Digit.
        /// </summary>
        public decimal? IdentifierCheckDigit { get; set; }

        /// <summary>
        /// XON.5 - Check Digit Scheme.
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// XON.6 - Assigning Authority.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V290.CodeAssigningAuthority</para>
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// XON.7 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V290.CodeIdentifierType</para>
        /// </summary>
        public string IdentifierTypeCode { get; set; }

        /// <summary>
        /// XON.8 - Assigning Facility.
        /// </summary>
        public HierarchicDesignator AssigningFacility { get; set; }

        /// <summary>
        /// XON.9 - Name Representation Code.
        /// <para>Suggested: 0465 Name/Address Representation -&gt; ClearHl7.Codes.V290.CodeNameAddressRepresentation</para>
        /// </summary>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// XON.10 - Organization Identifier.
        /// </summary>
        public string OrganizationIdentifier { get; set; }

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

            OrganizationName = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            OrganizationNameTypeCode = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], true, seps) : null;
            IdNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            IdentifierCheckDigit = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            CheckDigitScheme = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            AssigningAuthority = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[5], true, seps) : null;
            IdentifierTypeCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            AssigningFacility = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[7], true, seps) : null;
            NameRepresentationCode = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            OrganizationIdentifier = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 10, separator),
                                OrganizationName,
                                OrganizationNameTypeCode?.ToDelimitedString(),
                                IdNumber.HasValue ? IdNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                IdentifierCheckDigit.HasValue ? IdentifierCheckDigit.Value.ToString(Consts.NumericFormat, culture) : null,
                                CheckDigitScheme,
                                AssigningAuthority?.ToDelimitedString(),
                                IdentifierTypeCode,
                                AssigningFacility?.ToDelimitedString(),
                                NameRepresentationCode,
                                OrganizationIdentifier
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
