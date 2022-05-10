using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 ERL - Error Location.
    /// </summary>
    public class ErrorLocation : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLocation"/> class.
        /// </summary>
        public ErrorLocation()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLocation"/> class.
        /// </summary>
        /// <param name="segmentId">ERL.1 - Segment ID.</param>
        /// <param name="segmentSequence">ERL.2 - Segment Sequence.</param>
        public ErrorLocation(string segmentId, decimal segmentSequence)
        {
            SegmentId = segmentId;
            SegmentSequence = segmentSequence;
        }

        /// <inheritdoc/>
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

            SegmentId = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            SegmentSequence = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            FieldPosition = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            FieldRepetition = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            ComponentNumber = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            SubComponentNumber = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
