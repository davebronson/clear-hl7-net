using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 ELD - Error Location And Description.
    /// </summary>
    public class ErrorLocationAndDescription : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLocationAndDescription"/> class.
        /// </summary>
        public ErrorLocationAndDescription()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLocationAndDescription"/> class.
        /// </summary>
        /// <param name="segmentId">ELD.1 - Segment ID.</param>
        /// <param name="segmentSequence">ELD.2 - Segment Sequence.</param>
        /// <param name="fieldPosition">ELD.3 - Field Position.</param>
        /// <param name="codeIdentifyingError">ELD.4 - Code Identifying Error.</param>
        public ErrorLocationAndDescription(string segmentId, decimal segmentSequence, decimal fieldPosition, CodedElement codeIdentifyingError)
        {
            SegmentId = segmentId;
            SegmentSequence = segmentSequence;
            FieldPosition = fieldPosition;
            CodeIdentifyingError = codeIdentifyingError;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// ELD.1 - Segment ID.
        /// </summary>
        public string SegmentId { get; set; }

        /// <summary>
        /// ELD.2 - Segment Sequence.
        /// </summary>
        public decimal? SegmentSequence { get; set; }

        /// <summary>
        /// ELD.3 - Field Position.
        /// </summary>
        public decimal? FieldPosition { get; set; }

        /// <summary>
        /// ELD.4 - Code Identifying Error.
        /// <para>Suggested: 0357 Message Error Condition Codes -&gt; ClearHl7.Codes.V251.CodeMessageErrorConditionCodes</para>
        /// </summary>
        public CodedElement CodeIdentifyingError { get; set; }

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
            CodeIdentifyingError = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                SegmentId,
                                SegmentSequence.HasValue ? SegmentSequence.Value.ToString(Consts.NumericFormat, culture) : null,
                                FieldPosition.HasValue ? FieldPosition.Value.ToString(Consts.NumericFormat, culture) : null,
                                CodeIdentifyingError?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
