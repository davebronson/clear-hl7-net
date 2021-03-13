using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PES - Product Experience Sender.
    /// </summary>
    public class PesSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PES";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PES.1 - Sender Organization Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> SenderOrganizationName { get; set; }

        /// <summary>
        /// PES.2 - Sender Individual Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> SenderIndividualName { get; set; }

        /// <summary>
        /// PES.3 - Sender Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> SenderAddress { get; set; }

        /// <summary>
        /// PES.4 - Sender Telephone.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> SenderTelephone { get; set; }

        /// <summary>
        /// PES.5 - Sender Event Identifier.
        /// </summary>
        public EntityIdentifier SenderEventIdentifier { get; set; }

        /// <summary>
        /// PES.6 - Sender Sequence Number.
        /// </summary>
        public decimal? SenderSequenceNumber { get; set; }

        /// <summary>
        /// PES.7 - Sender Event Description.
        /// </summary>
        public IEnumerable<string> SenderEventDescription { get; set; }

        /// <summary>
        /// PES.8 - Sender Comment.
        /// </summary>
        public string SenderComment { get; set; }

        /// <summary>
        /// PES.9 - Sender Aware Date/Time.
        /// </summary>
        public DateTime? SenderAwareDateTime { get; set; }

        /// <summary>
        /// PES.10 - Event Report Date.
        /// </summary>
        public DateTime? EventReportDate { get; set; }

        /// <summary>
        /// PES.11 - Event Report Timing/Type.
        /// <para>Suggested: 0234 Report Timing -&gt; ClearHl7.Codes.V240.CodeReportTiming</para>
        /// </summary>
        public IEnumerable<string> EventReportTimingType { get; set; }

        /// <summary>
        /// PES.12 - Event Report Source.
        /// <para>Suggested: 0235 Report Source -&gt; ClearHl7.Codes.V240.CodeReportSource</para>
        /// </summary>
        public string EventReportSource { get; set; }

        /// <summary>
        /// PES.13 - Event Reported To.
        /// <para>Suggested: 0236 Event Reported To -&gt; ClearHl7.Codes.V240.CodeEventReportedTo</para>
        /// </summary>
        public IEnumerable<string> EventReportedTo { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 14, Configuration.FieldSeparator),
                                Id,
                                SenderOrganizationName != null ? string.Join(Configuration.FieldRepeatSeparator, SenderOrganizationName.Select(x => x.ToDelimitedString())) : null,
                                SenderIndividualName != null ? string.Join(Configuration.FieldRepeatSeparator, SenderIndividualName.Select(x => x.ToDelimitedString())) : null,
                                SenderAddress != null ? string.Join(Configuration.FieldRepeatSeparator, SenderAddress.Select(x => x.ToDelimitedString())) : null,
                                SenderTelephone != null ? string.Join(Configuration.FieldRepeatSeparator, SenderTelephone.Select(x => x.ToDelimitedString())) : null,
                                SenderEventIdentifier?.ToDelimitedString(),
                                SenderSequenceNumber.HasValue ? SenderSequenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                SenderEventDescription != null ? string.Join(Configuration.FieldRepeatSeparator, SenderEventDescription) : null,
                                SenderComment,
                                SenderAwareDateTime.HasValue ? SenderAwareDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventReportDate.HasValue ? EventReportDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventReportTimingType != null ? string.Join(Configuration.FieldRepeatSeparator, EventReportTimingType) : null,
                                EventReportSource,
                                EventReportedTo != null ? string.Join(Configuration.FieldRepeatSeparator, EventReportedTo) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}