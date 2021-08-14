using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CX - Extended Composite Id With Check Digit.
    /// </summary>
    public class ExtendedCompositeIdWithCheckDigit : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V282.CodeCheckDigitScheme</para>
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// CX.4 - Assigning Authority.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V282.CodeAssigningAuthority</para>
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// CX.5 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V282.CodeIdentifierType</para>
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

            IdNumber = segments.ElementAtOrDefault(0);
            IdentifierCheckDigit = segments.ElementAtOrDefault(1);
            CheckDigitScheme = segments.ElementAtOrDefault(2);
            AssigningAuthority = segments.Length > 3 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(3), true) : null;
            IdentifierTypeCode = segments.ElementAtOrDefault(4);
            AssigningFacility = segments.Length > 5 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(5), true) : null;
            EffectiveDate = segments.ElementAtOrDefault(6)?.ToNullableDateTime();
            ExpirationDate = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            AssigningJurisdiction = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), true) : null;
            AssigningAgencyOrDepartment = segments.Length > 9 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(9), true) : null;
            SecurityCheck = segments.ElementAtOrDefault(10);
            SecurityCheckScheme = segments.ElementAtOrDefault(11);
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
                                StringHelper.StringFormatSequence(0, 12, separator),
                                IdNumber,
                                IdentifierCheckDigit,
                                CheckDigitScheme,
                                AssigningAuthority?.ToDelimitedString(),
                                IdentifierTypeCode,
                                AssigningFacility?.ToDelimitedString(),
                                EffectiveDate.HasValue ? EffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                AssigningJurisdiction?.ToDelimitedString(),
                                AssigningAgencyOrDepartment?.ToDelimitedString(),
                                SecurityCheck,
                                SecurityCheckScheme
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
