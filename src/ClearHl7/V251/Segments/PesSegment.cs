using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// <para>Suggested: 0234 Report Timing -&gt; ClearHl7.Codes.V251.CodeReportTiming</para>
        /// </summary>
        public IEnumerable<string> EventReportTimingType { get; set; }

        /// <summary>
        /// PES.12 - Event Report Source.
        /// <para>Suggested: 0235 Report Source -&gt; ClearHl7.Codes.V251.CodeReportSource</para>
        /// </summary>
        public string EventReportSource { get; set; }

        /// <summary>
        /// PES.13 - Event Reported To.
        /// <para>Suggested: 0236 Event Reported To -&gt; ClearHl7.Codes.V251.CodeEventReportedTo</para>
        /// </summary>
        public IEnumerable<string> EventReportedTo { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SenderOrganizationName = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            SenderIndividualName = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            SenderAddress = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            SenderTelephone = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            SenderEventIdentifier = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[5], false) : null;
            SenderSequenceNumber = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            SenderEventDescription = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SenderComment = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            SenderAwareDateTime = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            EventReportDate = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
            EventReportTimingType = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            EventReportSource = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            EventReportedTo = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
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