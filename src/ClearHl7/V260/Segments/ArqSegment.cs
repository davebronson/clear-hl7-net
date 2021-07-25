using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ARQ - Appointment Request.
    /// </summary>
    public class ArqSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ARQ";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ARQ.1 - Placer Appointment ID.
        /// </summary>
        public EntityIdentifier PlacerAppointmentId { get; set; }

        /// <summary>
        /// ARQ.2 -  Filler Appointment ID.
        /// </summary>
        public EntityIdentifier FillerAppointmentId { get; set; }

        /// <summary>
        /// ARQ.3 - Occurrence Number.
        /// </summary>
        public decimal? OccurrenceNumber { get; set; }

        /// <summary>
        /// ARQ.4 - Placer Group Number.
        /// </summary>
        public EntityIdentifier PlacerGroupNumber { get; set; }

        /// <summary>
        /// ARQ.5 - Schedule ID.
        /// </summary>
        public CodedWithExceptions ScheduleId { get; set; }

        /// <summary>
        /// ARQ.6 - Request Event Reason.
        /// </summary>
        public CodedWithExceptions RequestEventReason { get; set; }

        /// <summary>
        /// ARQ.7 - Appointment Reason.
        /// <para>Suggested: 0276 Appointment Reason Codes -&gt; ClearHl7.Codes.V260.CodeAppointmentReasonCodes</para>
        /// </summary>
        public CodedWithExceptions AppointmentReason { get; set; }

        /// <summary>
        /// ARQ.8 - Appointment Type.
        /// <para>Suggested: 0277 Appointment Type Codes -&gt; ClearHl7.Codes.V260.CodeAppointmentTypeCodes</para>
        /// </summary>
        public CodedWithExceptions AppointmentType { get; set; }

        /// <summary>
        /// ARQ.9 - Appointment Duration.
        /// </summary>
        public decimal? AppointmentDuration { get; set; }

        /// <summary>
        /// ARQ.10 - Appointment Duration Units.
        /// </summary>
        public CodedWithNoExceptions AppointmentDurationUnits { get; set; }

        /// <summary>
        /// ARQ.11 - Requested Start Date/Time Range.
        /// </summary>
        public IEnumerable<DateTimeRange> RequestedStartDateTimeRange { get; set; }

        /// <summary>
        /// ARQ.12 - Priority-ARQ.
        /// </summary>
        public string PriorityArq { get; set; }

        /// <summary>
        /// ARQ.13 - Repeating Interval.
        /// </summary>
        public RepeatInterval RepeatingInterval { get; set; }

        /// <summary>
        /// ARQ.14 - Repeating Interval Duration.
        /// </summary>
        public string RepeatingIntervalDuration { get; set; }

        /// <summary>
        /// ARQ.15 - Placer Contact Person.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PlacerContactPerson { get; set; }

        /// <summary>
        /// ARQ.16 - Placer Contact Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> PlacerContactPhoneNumber { get; set; }

        /// <summary>
        /// ARQ.17 - Placer Contact Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> PlacerContactAddress { get; set; }

        /// <summary>
        /// ARQ.18 - Placer Contact Location.
        /// </summary>
        public PersonLocation PlacerContactLocation { get; set; }

        /// <summary>
        /// ARQ.19 - Entered By Person.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> EnteredByPerson { get; set; }

        /// <summary>
        /// ARQ.20 - Entered By Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> EnteredByPhoneNumber { get; set; }

        /// <summary>
        /// ARQ.21 - Entered By Location.
        /// </summary>
        public PersonLocation EnteredByLocation { get; set; }

        /// <summary>
        /// ARQ.22 - Parent Placer Appointment ID.
        /// </summary>
        public EntityIdentifier ParentPlacerAppointmentId { get; set; }

        /// <summary>
        /// ARQ.23 - Parent Filler Appointment ID.
        /// </summary>
        public EntityIdentifier ParentFillerAppointmentId { get; set; }

        /// <summary>
        /// ARQ.24 - Placer Order Number.
        /// </summary>
        public IEnumerable<EntityIdentifier> PlacerOrderNumber { get; set; }

        /// <summary>
        /// ARQ.25 - Filler Order Number.
        /// </summary>
        public IEnumerable<EntityIdentifier> FillerOrderNumber { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            PlacerAppointmentId = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            FillerAppointmentId = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            OccurrenceNumber = segments.ElementAtOrDefault(3)?.ToNullableDecimal();
            PlacerGroupNumber = segments.Length > 4 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(4), false) : null;
            ScheduleId = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            RequestEventReason = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(6), false) : null;
            AppointmentReason = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), false) : null;
            AppointmentType = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
            AppointmentDuration = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            AppointmentDurationUnits = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(10), false) : null;
            RequestedStartDateTimeRange = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator).Select(x => TypeHelper.Deserialize<DateTimeRange>(x, false)) : null;
            PriorityArq = segments.ElementAtOrDefault(12);
            RepeatingInterval = segments.Length > 13 ? TypeHelper.Deserialize<RepeatInterval>(segments.ElementAtOrDefault(13), false) : null;
            RepeatingIntervalDuration = segments.ElementAtOrDefault(14);
            PlacerContactPerson = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            PlacerContactPhoneNumber = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PlacerContactAddress = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            PlacerContactLocation = segments.Length > 18 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(18), false) : null;
            EnteredByPerson = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            EnteredByPhoneNumber = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            EnteredByLocation = segments.Length > 21 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(21), false) : null;
            ParentPlacerAppointmentId = segments.Length > 22 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(22), false) : null;
            ParentFillerAppointmentId = segments.Length > 23 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(23), false) : null;
            PlacerOrderNumber = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            FillerOrderNumber = segments.Length > 25 ? segments.ElementAtOrDefault(25).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 26, Configuration.FieldSeparator),
                                Id,
                                PlacerAppointmentId?.ToDelimitedString(),
                                FillerAppointmentId?.ToDelimitedString(),
                                OccurrenceNumber.HasValue ? OccurrenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                PlacerGroupNumber?.ToDelimitedString(),
                                ScheduleId?.ToDelimitedString(),
                                RequestEventReason?.ToDelimitedString(),
                                AppointmentReason?.ToDelimitedString(),
                                AppointmentType?.ToDelimitedString(),
                                AppointmentDuration.HasValue ? AppointmentDuration.Value.ToString(Consts.NumericFormat, culture) : null,
                                AppointmentDurationUnits?.ToDelimitedString(),
                                RequestedStartDateTimeRange != null ? string.Join(Configuration.FieldRepeatSeparator, RequestedStartDateTimeRange.Select(x => x.ToDelimitedString())) : null,
                                PriorityArq,
                                RepeatingInterval?.ToDelimitedString(),
                                RepeatingIntervalDuration,
                                PlacerContactPerson != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerContactPerson.Select(x => x.ToDelimitedString())) : null,
                                PlacerContactPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerContactPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                PlacerContactAddress != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerContactAddress.Select(x => x.ToDelimitedString())) : null,
                                PlacerContactLocation?.ToDelimitedString(),
                                EnteredByPerson != null ? string.Join(Configuration.FieldRepeatSeparator, EnteredByPerson.Select(x => x.ToDelimitedString())) : null,
                                EnteredByPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, EnteredByPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                EnteredByLocation?.ToDelimitedString(),
                                ParentPlacerAppointmentId?.ToDelimitedString(),
                                ParentFillerAppointmentId?.ToDelimitedString(),
                                PlacerOrderNumber != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerOrderNumber.Select(x => x.ToDelimitedString())) : null,
                                FillerOrderNumber != null ? string.Join(Configuration.FieldRepeatSeparator, FillerOrderNumber.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}