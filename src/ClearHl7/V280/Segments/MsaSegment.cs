using ClearHl7.Helpers;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MSA - Message Acknowledgment.
    /// </summary>
    public class MsaSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "MSA";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// MSA.1 - Acknowledgment Code.
        /// <para>Suggested: 0008 Acknowledgment Code -&gt; ClearHl7.Codes.V280.CodeAcknowledgmentCode</para>
        /// </summary>
        public string AcknowledgmentCode { get; set; }

        /// <summary>
        /// MSA.2 - Message Control ID.
        /// </summary>
        public string MessageControlId { get; set; }

        /// <summary>
        /// MSA.3 - Text Message.
        /// </summary>
        public string TextMessage { get; set; }

        /// <summary>
        /// MSA.4 - Expected Sequence Number.
        /// </summary>
        public decimal? ExpectedSequenceNumber { get; set; }

        /// <summary>
        /// MSA.5 - Delayed Acknowledgment Type.
        /// </summary>
        public string DelayedAcknowledgmentType { get; set; }

        /// <summary>
        /// MSA.6 - Error Condition.
        /// </summary>
        public string ErrorCondition { get; set; }

        /// <summary>
        /// MSA.7 - Message Waiting Number.
        /// </summary>
        public decimal? MessageWaitingNumber { get; set; }

        /// <summary>
        /// MSA.8 - Message Waiting Priority.
        /// <para>Suggested: 0520 Message Waiting Priority -&gt; ClearHl7.Codes.V280.CodeMessageWaitingPriority</para>
        /// </summary>
        public string MessageWaitingPriority { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                AcknowledgmentCode,
                                MessageControlId,
                                TextMessage,
                                ExpectedSequenceNumber.HasValue ? ExpectedSequenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                DelayedAcknowledgmentType,
                                ErrorCondition,
                                MessageWaitingNumber.HasValue ? MessageWaitingNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                MessageWaitingPriority
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}