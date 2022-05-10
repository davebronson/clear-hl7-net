using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 NR - Numeric Range.
    /// </summary>
    public class NumericRange : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericRange"/> class.
        /// </summary>
        public NumericRange()
        {

        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// NR.1 - Low Value.
        /// </summary>
        public decimal? LowValue { get; set; }

        /// <summary>
        /// NR.2 - High Value.
        /// </summary>
        public decimal? HighValue { get; set; }

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

            LowValue = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDecimal() : null;
            HighValue = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                LowValue.HasValue ? LowValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                HighValue.HasValue ? HighValue.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
