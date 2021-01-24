using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
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
        public ExtendedCompositeNameAndIdNumberForOrganizations SenderOrganizationName { get; set; }

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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0234</remarks>
        public IEnumerable<string> EventReportTimingType { get; set; }

        /// <summary>
        /// PES.12 - Event Report Source.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0235</remarks>
        public string EventReportSource { get; set; }

        /// <summary>
        /// PES.13 - Event Reported To.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0236</remarks>
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
                                SenderOrganizationName?.ToDelimitedString(),
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