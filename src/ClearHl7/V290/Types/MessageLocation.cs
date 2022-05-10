using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 ERL - Message Location.
    /// </summary>
    public class MessageLocation : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageLocation"/> class.
        /// </summary>
        public MessageLocation()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageLocation"/> class.
        /// </summary>
        /// <param name="segmentId">ERL.1 - Segment ID.</param>
        public MessageLocation(string segmentId)
        {
            SegmentId = segmentId;
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
        public uint? SegmentSequence { get; set; }

        /// <summary>
        /// ERL.3 - Field Position.
        /// </summary>
        public uint? FieldPosition { get; set; }

        /// <summary>
        /// ERL.4 - Field Repetition.
        /// </summary>
        public uint? FieldRepetition { get; set; }

        /// <summary>
        /// ERL.5 - Component Number.
        /// </summary>
        public uint? ComponentNumber { get; set; }

        /// <summary>
        /// ERL.6 - Sub-Component Number.
        /// </summary>
        public uint? SubComponentNumber { get; set; }

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
            SegmentSequence = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            FieldPosition = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableUInt() : null;
            FieldRepetition = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableUInt() : null;
            ComponentNumber = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableUInt() : null;
            SubComponentNumber = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableUInt() : null;
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
                                SegmentSequence.HasValue ? SegmentSequence.Value.ToString(culture) : null,
                                FieldPosition.HasValue ? FieldPosition.Value.ToString(culture) : null,
                                FieldRepetition.HasValue ? FieldRepetition.Value.ToString(culture) : null,
                                ComponentNumber.HasValue ? ComponentNumber.Value.ToString(culture) : null,
                                SubComponentNumber.HasValue ? SubComponentNumber.Value.ToString(culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
