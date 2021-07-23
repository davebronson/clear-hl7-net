using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 CK - Composite Id With Check Digit.
    /// </summary>
    public class CompositeIdWithCheckDigit : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CK.1 - ID Number.
        /// </summary>
        public decimal? IdNumber { get; set; }

        /// <summary>
        /// CK.2 - Check Digit.
        /// </summary>
        public decimal? CheckDigit { get; set; }

        /// <summary>
        /// CK.3 - Code Identifying The Check Digit Scheme Employed.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V231.CodeCheckDigitScheme</para>
        /// </summary>
        public string CodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

        /// <summary>
        /// CK.4 - Assigning Authority.
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            IdNumber = segments.ElementAtOrDefault(0)?.ToNullableDecimal();
            CheckDigit = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            CodeIdentifyingTheCheckDigitSchemeEmployed = segments.ElementAtOrDefault(2);
            AssigningAuthority = segments.Length > 3 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(3), true) : null;
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
                                StringHelper.StringFormatSequence(0, 4, separator),
                                IdNumber.HasValue ? IdNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                CheckDigit.HasValue ? CheckDigit.Value.ToString(Consts.NumericFormat, culture) : null,
                                CodeIdentifyingTheCheckDigitSchemeEmployed,
                                AssigningAuthority?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
