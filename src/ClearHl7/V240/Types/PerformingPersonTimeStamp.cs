using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
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
        /// <para>Suggested: 0360 Degree/License/Certificate -&gt; ClearHl7.Codes.V240.CodeDegreeLicenseCertificate</para>
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// PPN.8 - Source Table.
        /// <para>Suggested: 0297 Source Table</para>
        /// </summary>
        public string SourceTable { get; set; }

        /// <summary>
        /// PPN.9 - Assigning Authority.
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// PPN.10 - Name Type Code.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V240.CodeNameType</para>
        /// </summary>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// PPN.11 - Identifier Check Digit.
        /// </summary>
        public string IdentifierCheckDigit { get; set; }

        /// <summary>
        /// PPN.12 - Check Digit Scheme.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V240.CodeCheckDigitScheme</para>
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// PPN.13 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V240.CodeIdentifierType</para>
        /// </summary>
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
        /// <para>Suggested: 0465 Name/Address Representation -&gt; ClearHl7.Codes.V240.CodeNameAddressRepresentation</para>
        /// </summary>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// PPN.17 - Name Context.
        /// </summary>
        public CodedElement NameContext { get; set; }

        /// <summary>
        /// PPN.18 - Name Validity Range.
        /// </summary>
        public DateTimeRange NameValidityRange { get; set; }

        /// <summary>
        /// PPN.19 - Name Assembly Order.
        /// <para>Suggested: 0444 Name Assembly Order -&gt; ClearHl7.Codes.V240.CodeNameAssemblyOrder</para>
        /// </summary>
        public string NameAssemblyOrder { get; set; }

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
            SourceTable = segments.ElementAtOrDefault(7);
            AssigningAuthority = segments.Length > 8 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(8), true) : null;
            NameTypeCode = segments.ElementAtOrDefault(9);
            IdentifierCheckDigit = segments.ElementAtOrDefault(10);
            CheckDigitScheme = segments.ElementAtOrDefault(11);
            IdentifierTypeCode = segments.ElementAtOrDefault(12);
            AssigningFacility = segments.Length > 13 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(13), true) : null;
            DateTimeActionPerformed = segments.ElementAtOrDefault(14)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            NameRepresentationCode = segments.ElementAtOrDefault(15);
            NameContext = segments.Length > 16 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(16), true) : null;
            NameValidityRange = segments.Length > 17 ? TypeHelper.Deserialize<DateTimeRange>(segments.ElementAtOrDefault(17), true) : null;
            NameAssemblyOrder = segments.ElementAtOrDefault(18);
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
                                StringHelper.StringFormatSequence(0, 19, separator),
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
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
