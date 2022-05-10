using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 SN - Structured Numeric.
    /// </summary>
    public class StructuredNumeric : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredNumeric"/> class.
        /// </summary>
        public StructuredNumeric()
        {

        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SN.1 - Comparator.
        /// </summary>
        public string Comparator { get; set; }

        /// <summary>
        /// SN.2 - Num1.
        /// </summary>
        public decimal? Num1 { get; set; }

        /// <summary>
        /// SN.3 - Separator/Suffix.
        /// </summary>
        public string SeparatorSuffix { get; set; }

        /// <summary>
        /// SN.4 - Num2.
        /// </summary>
        public decimal? Num2 { get; set; }

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

            Comparator = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            Num1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            SeparatorSuffix = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Num2 = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                Comparator,
                                Num1.HasValue ? Num1.Value.ToString(Consts.NumericFormat, culture) : null,
                                SeparatorSuffix,
                                Num2.HasValue ? Num2.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
