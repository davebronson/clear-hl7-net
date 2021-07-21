using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
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
        /// <para>Suggested: 0204 Organizational Name Type -&gt; ClearHl7.Codes.V230.CodeOrganizationalNameType</para>
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
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V230.CodeCheckDigitScheme</para>
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// XON.6 - Assigning Authority.
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// XON.7 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V230.CodeIdentifierType</para>
        /// </summary>
        public string IdentifierTypeCode { get; set; }

        /// <summary>
        /// XON.8 - Assigning Facility.
        /// </summary>
        public HierarchicDesignator AssigningFacility { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            OrganizationName = segments.ElementAtOrDefault(0);
            OrganizationNameTypeCode = segments.ElementAtOrDefault(1);
            IdNumber = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            IdentifierCheckDigit = segments.ElementAtOrDefault(3)?.ToNullableDecimal();
            CheckDigitScheme = segments.ElementAtOrDefault(4);

            if (segments.Length > 5)
            {
                AssigningAuthority = new HierarchicDesignator { IsSubcomponent = true };
                AssigningAuthority.FromDelimitedString(segments.ElementAtOrDefault(5));
            }
            else
            {
                AssigningAuthority = null;
            }

            IdentifierTypeCode = segments.ElementAtOrDefault(6);

            if (segments.Length > 7)
            {
                AssigningFacility = new HierarchicDesignator { IsSubcomponent = true };
                AssigningFacility.FromDelimitedString(segments.ElementAtOrDefault(7));
            }
            else
            {
                AssigningFacility = null;
            }
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
                                StringHelper.StringFormatSequence(0, 8, separator),
                                OrganizationName,
                                OrganizationNameTypeCode,
                                IdNumber.HasValue ? IdNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                IdentifierCheckDigit.HasValue ? IdentifierCheckDigit.Value.ToString(Consts.NumericFormat, culture) : null,
                                CheckDigitScheme,
                                AssigningAuthority?.ToDelimitedString(),
                                IdentifierTypeCode,
                                AssigningFacility?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
