using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MSA - Message Acknowledgment.
    /// </summary>
    public class MsaSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MsaSegment"/> class.
        /// </summary>
        public MsaSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MsaSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public MsaSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id { get; } = "MSA";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// MSA.1 - Acknowledgment Code.
        /// <para>Suggested: 0008 Acknowledgment Code -&gt; ClearHl7.Codes.V281.CodeAcknowledgmentCode</para>
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
        /// <para>Suggested: 0520 Message Waiting Priority -&gt; ClearHl7.Codes.V281.CodeMessageWaitingPriority</para>
        /// </summary>
        public string MessageWaitingPriority { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            AcknowledgmentCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            MessageControlId = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            TextMessage = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            ExpectedSequenceNumber = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            DelayedAcknowledgmentType = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            ErrorCondition = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            MessageWaitingNumber = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            MessageWaitingPriority = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
