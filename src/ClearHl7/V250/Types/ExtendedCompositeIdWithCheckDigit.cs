using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V250.Types
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
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V250.CodeCheckDigitScheme</para>
        /// </summary>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// CX.4 - Assigning Authority.
        /// <para>Suggested: 0363 Assigning Authority</para>
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// CX.5 - Identifier Type Code.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V250.CodeIdentifierType</para>
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

            if (segments.Length > 3)
            {
                AssigningAuthority = new HierarchicDesignator { IsSubcomponent = true };
                AssigningAuthority.FromDelimitedString(segments.ElementAtOrDefault(3));
            }
            else
            {
                AssigningAuthority = null;
            }

            IdentifierTypeCode = segments.ElementAtOrDefault(4);

            if (segments.Length > 5)
            {
                AssigningFacility = new HierarchicDesignator { IsSubcomponent = true };
                AssigningFacility.FromDelimitedString(segments.ElementAtOrDefault(5));
            }
            else
            {
                AssigningFacility = null;
            }

            EffectiveDate = segments.ElementAtOrDefault(6)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            ExpirationDate = segments.ElementAtOrDefault(7)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);

            if (segments.Length > 8)
            {
                AssigningJurisdiction = new CodedWithExceptions { IsSubcomponent = true };
                AssigningJurisdiction.FromDelimitedString(segments.ElementAtOrDefault(8));
            }
            else
            {
                AssigningJurisdiction = null;
            }

            if (segments.Length > 9)
            {
                AssigningAgencyOrDepartment = new CodedWithExceptions { IsSubcomponent = true };
                AssigningAgencyOrDepartment.FromDelimitedString(segments.ElementAtOrDefault(9));
            }
            else
            {
                AssigningAgencyOrDepartment = null;
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
                                StringHelper.StringFormatSequence(0, 10, separator),
                                IdNumber,
                                IdentifierCheckDigit,
                                CheckDigitScheme,
                                AssigningAuthority?.ToDelimitedString(),
                                IdentifierTypeCode,
                                AssigningFacility?.ToDelimitedString(),
                                EffectiveDate.HasValue ? EffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                AssigningJurisdiction?.ToDelimitedString(),
                                AssigningAgencyOrDepartment?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
