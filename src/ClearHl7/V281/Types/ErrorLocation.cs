using System;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 ERL - Error Location.
    /// </summary>
    public class ErrorLocation : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// ERL.1 - Segment ID.
        /// </summary>
        public string SegmentId { get; set; }

        /// <summary>
        /// ERL.2 - Segment Sequence.
        /// </summary>
        public decimal? SegmentSequence { get; set; }

        /// <summary>
        /// ERL.3 - Field Position.
        /// </summary>
        public decimal? FieldPosition { get; set; }

        /// <summary>
        /// ERL.4 - Field Repetition.
        /// </summary>
        public decimal? FieldRepetition { get; set; }

        /// <summary>
        /// ERL.5 - Component Number.
        /// </summary>
        public decimal? ComponentNumber { get; set; }

        /// <summary>
        /// ERL.6 - Sub-Component Number.
        /// </summary>
        public decimal? SubComponentNumber { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            SegmentId = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            SegmentSequence = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            FieldPosition = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            FieldRepetition = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            ComponentNumber = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            SubComponentNumber = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
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
                                StringHelper.StringFormatSequence(0, 6, separator),
                                SegmentId,
                                SegmentSequence.HasValue ? SegmentSequence.Value.ToString(Consts.NumericFormat, culture) : null,
                                FieldPosition.HasValue ? FieldPosition.Value.ToString(Consts.NumericFormat, culture) : null,
                                FieldRepetition.HasValue ? FieldRepetition.Value.ToString(Consts.NumericFormat, culture) : null,
                                ComponentNumber.HasValue ? ComponentNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                SubComponentNumber.HasValue ? SubComponentNumber.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
