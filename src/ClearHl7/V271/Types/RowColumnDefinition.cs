using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 RCD - Row Column Definition.
    /// </summary>
    public class RowColumnDefinition : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RowColumnDefinition"/> class.
        /// </summary>
        public RowColumnDefinition()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RowColumnDefinition"/> class.
        /// </summary>
        /// <param name="segmentFieldName">RCD.1 - Segment Field Name.</param>
        /// <param name="hl7DataType">RCD.2 - HL7 Data Type.</param>
        public RowColumnDefinition(string segmentFieldName, string hl7DataType)
        {
            SegmentFieldName = segmentFieldName;
            Hl7DataType = hl7DataType;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RCD.1 - Segment Field Name.
        /// </summary>
        public string SegmentFieldName { get; set; }

        /// <summary>
        /// RCD.2 - HL7 Data Type.
        /// <para>Suggested: 0440 Data Types -&gt; ClearHl7.Codes.V271.CodeDataTypes</para>
        /// </summary>
        public string Hl7DataType { get; set; }

        /// <summary>
        /// RCD.3 - Maximum Column Width.
        /// </summary>
        public decimal? MaximumColumnWidth { get; set; }

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

            SegmentFieldName = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            Hl7DataType = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            MaximumColumnWidth = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                SegmentFieldName,
                                Hl7DataType,
                                MaximumColumnWidth.HasValue ? MaximumColumnWidth.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
