using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 XON - Extended Composite Name And Identification Number For Organizations.
    /// </summary>
    public class ExtendedCompositeNameAndIdNumberForOrganizations : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// XON.1 - Organization Name.
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// XON.2 - Organization Name Type Code.
        /// <para>Suggested: 0204 Organizational Name Type -&gt; ClearHl7.Codes.V231.CodeOrganizationalNameType</para>
        /// </summary>
        public string OrganizationNameTypeCode { get; set; }

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
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V231.CodeCheckDigitScheme</para>
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// XON.6 - Assigning Authority.
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// XON.7 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V231.CodeIdentifierType</para>
        /// </summary>
        public string IdentifierTypeCode { get; set; }

        /// <summary>
        /// XON.8 - Assigning Facility.
        /// </summary>
        public HierarchicDesignator AssigningFacility { get; set; }

        /// <summary>
        /// XON.9 - Name Representation Code.
        /// <para>Suggested: 4000 Name/Address Representation -&gt; ClearHl7.Codes.V231.CodeNameAddressRepresentation</para>
        /// </summary>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            OrganizationName = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            OrganizationNameTypeCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            IdNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            IdentifierCheckDigit = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            CheckDigitScheme = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            AssigningAuthority = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[5], true) : null;
            IdentifierTypeCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            AssigningFacility = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[7], true) : null;
            NameRepresentationCode = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
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
                                StringHelper.StringFormatSequence(0, 9, separator),
                                OrganizationName,
                                OrganizationNameTypeCode,
                                IdNumber.HasValue ? IdNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                IdentifierCheckDigit.HasValue ? IdentifierCheckDigit.Value.ToString(Consts.NumericFormat, culture) : null,
                                CheckDigitScheme,
                                AssigningAuthority?.ToDelimitedString(),
                                IdentifierTypeCode,
                                AssigningFacility?.ToDelimitedString(),
                                NameRepresentationCode
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
