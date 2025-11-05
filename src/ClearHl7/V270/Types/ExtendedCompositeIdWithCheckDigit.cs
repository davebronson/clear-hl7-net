using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 CX - Extended Composite Id With Check Digit.
    /// </summary>
    public class ExtendedCompositeIdWithCheckDigit : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedCompositeIdWithCheckDigit"/> class.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedCompositeIdWithCheckDigit"/> class.
        /// </summary>
        /// <param name="idNumber">CX.1 - ID Number.</param>
        public ExtendedCompositeIdWithCheckDigit(string idNumber)
        {
            IdNumber = idNumber;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CX.1 - ID Number.
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// CX.2 - Identifier Check Digit.
        /// </summary>
        public string IdentifierCheckDigit { get; set; }

        /// <summary>
        /// CX.3 - Check Digit Scheme.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V270.CodeCheckDigitScheme</para>
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// CX.4 - Assigning Authority.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V270.CodeAssigningAuthority</para>
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// CX.5 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V270.CodeIdentifierType</para>
        /// </summary>
        public string IdentifierTypeCode { get; set; }

        /// <summary>
        /// CX.6 - Assigning Facility.
        /// </summary>
        public HierarchicDesignator AssigningFacility { get; set; }

        /// <summary>
        /// CX.7 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// CX.8 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// CX.9 - Assigning Jurisdiction.
        /// </summary>
        public CodedWithExceptions AssigningJurisdiction { get; set; }

        /// <summary>
        /// CX.10 - Assigning Agency or Department.
        /// </summary>
        public CodedWithExceptions AssigningAgencyOrDepartment { get; set; }

        /// <summary>
        /// CX.11 - Security Check.
        /// </summary>
        public string SecurityCheck { get; set; }

        /// <summary>
        /// CX.12 - Security Check Scheme.
        /// <para>Suggested: 0904 Security Check Scheme -&gt; ClearHl7.Codes.V270.CodeSecurityCheckScheme</para>
        /// </summary>
        public string SecurityCheckScheme { get; set; }

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

            IdNumber = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            IdentifierCheckDigit = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            CheckDigitScheme = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            AssigningAuthority = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[3], true, seps) : null;
            IdentifierTypeCode = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            AssigningFacility = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[5], true, seps) : null;
            EffectiveDate = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            ExpirationDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            AssigningJurisdiction = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], true, seps) : null;
            AssigningAgencyOrDepartment = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], true, seps) : null;
            SecurityCheck = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            SecurityCheckScheme = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 12, separator),
                                IdNumber,
                                IdentifierCheckDigit,
                                CheckDigitScheme,
                                AssigningAuthority?.ToDelimitedString(),
                                IdentifierTypeCode,
                                AssigningFacility?.ToDelimitedString(),
                                EffectiveDate?.ToHl7DateTimeString(typeof(ExtendedCompositeIdWithCheckDigit), nameof(EffectiveDate), Consts.DateFormatPrecisionDay, culture),
                                ExpirationDate?.ToHl7DateTimeString(typeof(ExtendedCompositeIdWithCheckDigit), nameof(ExpirationDate), Consts.DateFormatPrecisionDay, culture),
                                AssigningJurisdiction?.ToDelimitedString(),
                                AssigningAgencyOrDepartment?.ToDelimitedString(),
                                SecurityCheck,
                                SecurityCheckScheme
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
