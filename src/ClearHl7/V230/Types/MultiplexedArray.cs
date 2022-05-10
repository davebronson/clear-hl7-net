using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
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
        /// MA.1 - Sample 1 From Channel 1.
        /// </summary>
        public decimal? Sample1FromChannel1 { get; set; }

        /// <summary>
        /// MA.2 - Sample 1 From Channel 2.
        /// </summary>
        public decimal? Sample1FromChannel2 { get; set; }

        /// <summary>
        /// MA.3 - Sample 1 From Channel N.
        /// </summary>
        public decimal? Sample1FromChannelN { get; set; }

        /// <summary>
        /// MA.4 - Sample 2 From Channel 1.
        /// </summary>
        public decimal? Sample2FromChannel1 { get; set; }

        /// <summary>
        /// MA.5 - Sample 2 From Channel N.
        /// </summary>
        public decimal? Sample2FromChannelN { get; set; }

        /// <summary>
        /// MA.6 - Sample N From Channel N.
        /// </summary>
        public decimal? SampleNFromChannelN { get; set; }

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

            Sample1FromChannel1 = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDecimal() : null;
            Sample1FromChannel2 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            Sample1FromChannelN = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            Sample2FromChannel1 = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            Sample2FromChannelN = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            SampleNFromChannelN = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, separator),
                                Sample1FromChannel1.HasValue ? Sample1FromChannel1.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sample1FromChannel2.HasValue ? Sample1FromChannel2.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sample1FromChannelN.HasValue ? Sample1FromChannelN.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sample2FromChannel1.HasValue ? Sample2FromChannel1.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sample2FromChannelN.HasValue ? Sample2FromChannelN.Value.ToString(Consts.NumericFormat, culture) : null,
                                SampleNFromChannelN.HasValue ? SampleNFromChannelN.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
