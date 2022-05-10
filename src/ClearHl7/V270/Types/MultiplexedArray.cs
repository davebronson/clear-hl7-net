using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 MA - Multiplexed Array.
    /// </summary>
    public class MultiplexedArray : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplexedArray"/> class.
        /// </summary>
        public MultiplexedArray()
        {

        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MA.1 - Sample Y From Channel 1.
        /// </summary>
        public decimal? SampleYFromChannel1 { get; set; }

        /// <summary>
        /// MA.2 - Sample Y From Channel 2.
        /// </summary>
        public decimal? SampleYFromChannel2 { get; set; }

        /// <summary>
        /// MA.3 - Sample Y From Channel 3.
        /// </summary>
        public decimal? SampleYFromChannel3 { get; set; }

        /// <summary>
        /// MA.4 - Sample Y From Channel 4.
        /// </summary>
        public decimal? SampleYFromChannel4 { get; set; }

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

            SampleYFromChannel1 = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDecimal() : null;
            SampleYFromChannel2 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            SampleYFromChannel3 = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            SampleYFromChannel4 = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                SampleYFromChannel1.HasValue ? SampleYFromChannel1.Value.ToString(Consts.NumericFormat, culture) : null,
                                SampleYFromChannel2.HasValue ? SampleYFromChannel2.Value.ToString(Consts.NumericFormat, culture) : null,
                                SampleYFromChannel3.HasValue ? SampleYFromChannel3.Value.ToString(Consts.NumericFormat, culture) : null,
                                SampleYFromChannel4.HasValue ? SampleYFromChannel4.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
