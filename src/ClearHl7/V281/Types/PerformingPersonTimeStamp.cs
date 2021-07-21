using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
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
        /// <para>Suggested: 0297 Source Table</para>
        /// </summary>
        public CodedWithExceptions SourceTable { get; set; }

        /// <summary>
        /// PPN.9 - Assigning Authority.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V281.CodeAssigningAuthority</para>
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// PPN.10 - Name Type Code.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V281.CodeNameType</para>
        /// </summary>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// PPN.11 - Identifier Check Digit.
        /// </summary>
        public string IdentifierCheckDigit { get; set; }

        /// <summary>
        /// PPN.12 - Check Digit Scheme.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V281.CodeCheckDigitScheme</para>
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// PPN.13 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V281.CodeIdentifierType</para>
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
        /// <para>Suggested: 0465 Name/Address Representation -&gt; ClearHl7.Codes.V281.CodeNameAddressRepresentation</para>
        /// </summary>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// PPN.17 - Name Context.
        /// <para>Suggested: 0448 Name Context</para>
        /// </summary>
        public CodedWithExceptions NameContext { get; set; }

        /// <summary>
        /// PPN.18 - Name Validity Range.
        /// </summary>
        public string NameValidityRange { get; set; }

        /// <summary>
        /// PPN.19 - Name Assembly Order.
        /// <para>Suggested: 0444 Name Assembly Order -&gt; ClearHl7.Codes.V281.CodeNameAssemblyOrder</para>
        /// </summary>
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
        /// <para>Suggested: 0904 Security Check Scheme -&gt; ClearHl7.Codes.V281.CodeSecurityCheckScheme</para>
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

            if (segments.Length > 1)
            {
                FamilyName = new FamilyName { IsSubcomponent = true };
                FamilyName.FromDelimitedString(segments.ElementAtOrDefault(1));
            }
            else
            {
                FamilyName = null;
            }

            GivenName = segments.ElementAtOrDefault(2);
            SecondAndFurtherGivenNamesOrInitialsThereof = segments.ElementAtOrDefault(3);
            Suffix = segments.ElementAtOrDefault(4);
            Prefix = segments.ElementAtOrDefault(5);
            Degree = segments.ElementAtOrDefault(6);

            if (segments.Length > 7)
            {
                SourceTable = new CodedWithExceptions { IsSubcomponent = true };
                SourceTable.FromDelimitedString(segments.ElementAtOrDefault(7));
            }
            else
            {
                SourceTable = null;
            }

            if (segments.Length > 8)
            {
                AssigningAuthority = new HierarchicDesignator { IsSubcomponent = true };
                AssigningAuthority.FromDelimitedString(segments.ElementAtOrDefault(8));
            }
            else
            {
                AssigningAuthority = null;
            }

            NameTypeCode = segments.ElementAtOrDefault(9);
            IdentifierCheckDigit = segments.ElementAtOrDefault(10);
            CheckDigitScheme = segments.ElementAtOrDefault(11);
            IdentifierTypeCode = segments.ElementAtOrDefault(12);

            if (segments.Length > 13)
            {
                AssigningFacility = new HierarchicDesignator { IsSubcomponent = true };
                AssigningFacility.FromDelimitedString(segments.ElementAtOrDefault(13));
            }
            else
            {
                AssigningFacility = null;
            }

            DateTimeActionPerformed = segments.ElementAtOrDefault(14)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            NameRepresentationCode = segments.ElementAtOrDefault(15);

            if (segments.Length > 16)
            {
                NameContext = new CodedWithExceptions { IsSubcomponent = true };
                NameContext.FromDelimitedString(segments.ElementAtOrDefault(16));
            }
            else
            {
                NameContext = null;
            }

            NameValidityRange = segments.ElementAtOrDefault(17);
            NameAssemblyOrder = segments.ElementAtOrDefault(18);
            EffectiveDate = segments.ElementAtOrDefault(19)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ExpirationDate = segments.ElementAtOrDefault(20)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ProfessionalSuffix = segments.ElementAtOrDefault(21);

            if (segments.Length > 22)
            {
                AssigningJurisdiction = new CodedWithExceptions { IsSubcomponent = true };
                AssigningJurisdiction.FromDelimitedString(segments.ElementAtOrDefault(22));
            }
            else
            {
                AssigningJurisdiction = null;
            }

            if (segments.Length > 23)
            {
                AssigningAgencyOrDepartment = new CodedWithExceptions { IsSubcomponent = true };
                AssigningAgencyOrDepartment.FromDelimitedString(segments.ElementAtOrDefault(23));
            }
            else
            {
                AssigningAgencyOrDepartment = null;
            }

            SecurityCheck = segments.ElementAtOrDefault(24);
            SecurityCheckScheme = segments.ElementAtOrDefault(25);
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
