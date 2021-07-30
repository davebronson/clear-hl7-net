using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V260.Segments
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
        /// <para>Suggested: 0008 Acknowledgment Code -&gt; ClearHl7.Codes.V260.CodeAcknowledgmentCode</para>
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
        /// <para>Suggested: 0357 Message Error Condition Codes -&gt; ClearHl7.Codes.V260.CodeMessageErrorConditionCodes</para>
        /// </summary>
        public string ErrorCondition { get; set; }

        /// <summary>
        /// MSA.7 - Message Waiting Number.
        /// </summary>
        public decimal? MessageWaitingNumber { get; set; }

        /// <summary>
        /// MSA.8 - Message Waiting Priority.
        /// <para>Suggested: 0520 Message Waiting Priority -&gt; ClearHl7.Codes.V260.CodeMessageWaitingPriority</para>
        /// </summary>
        public string MessageWaitingPriority { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            AcknowledgmentCode = segments.ElementAtOrDefault(1);
            MessageControlId = segments.ElementAtOrDefault(2);
            TextMessage = segments.ElementAtOrDefault(3);
            ExpectedSequenceNumber = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            DelayedAcknowledgmentType = segments.ElementAtOrDefault(5);
            ErrorCondition = segments.ElementAtOrDefault(6);
            MessageWaitingNumber = segments.ElementAtOrDefault(7)?.ToNullableDecimal();
            MessageWaitingPriority = segments.ElementAtOrDefault(8);
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
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