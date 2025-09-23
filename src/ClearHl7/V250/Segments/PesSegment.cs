using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PES - Product Experience Sender.
    /// </summary>
    public class PesSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PesSegment"/> class.
        /// </summary>
        public PesSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PesSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PesSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PES";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0234 Report Timing -&gt; ClearHl7.Codes.V250.CodeReportTiming</para>
        /// </summary>
        public IEnumerable<string> EventReportTimingType { get; set; }

        /// <summary>
        /// PES.12 - Event Report Source.
        /// <para>Suggested: 0235 Report Source -&gt; ClearHl7.Codes.V250.CodeReportSource</para>
        /// </summary>
        public string EventReportSource { get; set; }

        /// <summary>
        /// PES.13 - Event Reported To.
        /// <para>Suggested: 0236 Event Reported To -&gt; ClearHl7.Codes.V250.CodeEventReportedTo</para>
        /// </summary>
        public IEnumerable<string> EventReportedTo { get; set; }

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
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SenderOrganizationName = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            SenderIndividualName = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            SenderAddress = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            SenderTelephone = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            SenderEventIdentifier = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[5], false, seps) : null;
            SenderSequenceNumber = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            SenderEventDescription = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SenderComment = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            SenderAwareDateTime = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            EventReportDate = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
            EventReportTimingType = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            EventReportSource = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            EventReportedTo = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
                                SenderAwareDateTime.ToHl7DateTimeString(typeof(PesSegment), nameof(SenderAwareDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EventReportDate.ToHl7DateTimeString(typeof(PesSegment), nameof(EventReportDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                EventReportTimingType != null ? string.Join(Configuration.FieldRepeatSeparator, EventReportTimingType) : null,
                                EventReportSource,
                                EventReportedTo != null ? string.Join(Configuration.FieldRepeatSeparator, EventReportedTo) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
