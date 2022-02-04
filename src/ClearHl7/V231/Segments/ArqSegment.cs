using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ARQ - Appointment Request.
    /// </summary>
    public class ArqSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArqSegment"/> class.
        /// </summary>
        public ArqSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArqSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public ArqSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "ARQ";

        /// <inheritdoc/>
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
        public CodedElement ScheduleId { get; set; }

        /// <summary>
        /// ARQ.6 - Request Event Reason.
        /// </summary>
        public CodedElement RequestEventReason { get; set; }

        /// <summary>
        /// ARQ.7 - Appointment Reason.
        /// <para>Suggested: 0276 Appointment Reason Codes -&gt; ClearHl7.Codes.V231.CodeAppointmentReasonCodes</para>
        /// </summary>
        public CodedElement AppointmentReason { get; set; }

        /// <summary>
        /// ARQ.8 - Appointment Type.
        /// <para>Suggested: 0277 Appointment Type Codes -&gt; ClearHl7.Codes.V231.CodeAppointmentTypeCodes</para>
        /// </summary>
        public CodedElement AppointmentType { get; set; }

        /// <summary>
        /// ARQ.9 - Appointment Duration.
        /// </summary>
        public decimal? AppointmentDuration { get; set; }

        /// <summary>
        /// ARQ.10 - Appointment Duration Units.
        /// </summary>
        public CodedElement AppointmentDurationUnits { get; set; }

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

            PlacerAppointmentId = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            FillerAppointmentId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            OccurrenceNumber = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            PlacerGroupNumber = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            ScheduleId = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[5], false, seps) : null;
            RequestEventReason = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[6], false, seps) : null;
            AppointmentReason = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[7], false, seps) : null;
            AppointmentType = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[8], false, seps) : null;
            AppointmentDuration = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            AppointmentDurationUnits = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[10], false, seps) : null;
            RequestedStartDateTimeRange = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<DateTimeRange>(x, false, seps)) : null;
            PriorityArq = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            RepeatingInterval = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<RepeatInterval>(segments[13], false, seps) : null;
            RepeatingIntervalDuration = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            PlacerContactPerson = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            PlacerContactPhoneNumber = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            PlacerContactAddress = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            PlacerContactLocation = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[18], false, seps) : null;
            EnteredByPerson = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            EnteredByPhoneNumber = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            EnteredByLocation = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[21], false, seps) : null;
            ParentPlacerAppointmentId = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[22], false, seps) : null;
            ParentFillerAppointmentId = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[23], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 24, Configuration.FieldSeparator),
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
                                ParentFillerAppointmentId?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
