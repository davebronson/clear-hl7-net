using System;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0008</remarks>
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
        /// <remarks>https://www.hl7.org/fhir/v2/0357</remarks>
        public CodedElement ErrorCondition { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}",
                                Id,
                                AcknowledgmentCode,
                                MessageControlId,
                                TextMessage,
                                ExpectedSequenceNumber.HasValue ? ExpectedSequenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                DelayedAcknowledgmentType,
                                ErrorCondition
                                ).TrimEnd('|');
        }
    }
}