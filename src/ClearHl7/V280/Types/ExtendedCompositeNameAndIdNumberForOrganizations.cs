﻿using ClearHl7.Helpers;

namespace ClearHl7.V280.Types
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
        /// <para>Suggested: 0204 Organizational Name Type -&gt; ClearHl7.Codes.V280.CodeOrganizationalNameType</para>
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
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V280.CodeAssigningAuthority</para>
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// XON.7 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V280.CodeIdentifierType</para>
        /// </summary>
        public string IdentifierTypeCode { get; set; }

        /// <summary>
        /// XON.8 - Assigning Facility.
        /// </summary>
        public HierarchicDesignator AssigningFacility { get; set; }

        /// <summary>
        /// XON.9 - Name Representation Code.
        /// <para>Suggested: 0465 Name/Address Representation -&gt; ClearHl7.Codes.V280.CodeNameAddressRepresentation</para>
        /// </summary>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// XON.10 - Organization Identifier.
        /// </summary>
        public string OrganizationIdentifier { get; set; }

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
