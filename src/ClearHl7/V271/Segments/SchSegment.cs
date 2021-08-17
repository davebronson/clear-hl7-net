using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SCH - Scheduling Activity Information.
    /// </summary>
    public class SchSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SCH";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SCH.1 - Placer Appointment ID.
        /// </summary>
        public EntityIdentifier PlacerAppointmentId { get; set; }

        /// <summary>
        /// SCH.2 - Filler Appointment ID.
        /// </summary>
        public EntityIdentifier FillerAppointmentId { get; set; }

        /// <summary>
        /// SCH.3 - Occurrence Number.
        /// </summary>
        public decimal? OccurrenceNumber { get; set; }

        /// <summary>
        /// SCH.4 - Placer Group Number.
        /// </summary>
        public EntityIdentifier PlacerGroupNumber { get; set; }

        /// <summary>
        /// SCH.5 - Schedule ID.
        /// </summary>
        public CodedWithExceptions ScheduleId { get; set; }

        /// <summary>
        /// SCH.6 - Event Reason.
        /// </summary>
        public CodedWithExceptions EventReason { get; set; }

        /// <summary>
        /// SCH.7 - Appointment Reason.
        /// <para>Suggested: 0276 Appointment Reason Codes -&gt; ClearHl7.Codes.V271.CodeAppointmentReasonCodes</para>
        /// </summary>
        public CodedWithExceptions AppointmentReason { get; set; }

        /// <summary>
        /// SCH.8 - Appointment Type.
        /// <para>Suggested: 0277 Appointment Type Codes -&gt; ClearHl7.Codes.V271.CodeAppointmentTypeCodes</para>
        /// </summary>
        public CodedWithExceptions AppointmentType { get; set; }

        /// <summary>
        /// SCH.9 - Appointment Duration.
        /// </summary>
        public decimal? AppointmentDuration { get; set; }

        /// <summary>
        /// SCH.10 - Appointment Duration Units.
        /// </summary>
        public CodedWithNoExceptions AppointmentDurationUnits { get; set; }

        /// <summary>
        /// SCH.11 - Appointment Timing Quantity.
        /// </summary>
        public string AppointmentTimingQuantity { get; set; }

        /// <summary>
        /// SCH.12 - Placer Contact Person.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PlacerContactPerson { get; set; }

        /// <summary>
        /// SCH.13 - Placer Contact Phone Number.
        /// </summary>
        public ExtendedTelecommunicationNumber PlacerContactPhoneNumber { get; set; }

        /// <summary>
        /// SCH.14 - Placer Contact Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> PlacerContactAddress { get; set; }

        /// <summary>
        /// SCH.15 - Placer Contact Location.
        /// </summary>
        public PersonLocation PlacerContactLocation { get; set; }

        /// <summary>
        /// SCH.16 - Filler Contact Person.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> FillerContactPerson { get; set; }

        /// <summary>
        /// SCH.17 - Filler Contact Phone Number.
        /// </summary>
        public ExtendedTelecommunicationNumber FillerContactPhoneNumber { get; set; }

        /// <summary>
        /// SCH.18 - Filler Contact Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> FillerContactAddress { get; set; }

        /// <summary>
        /// SCH.19 - Filler Contact Location.
        /// </summary>
        public PersonLocation FillerContactLocation { get; set; }

        /// <summary>
        /// SCH.20 - Entered By Person.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> EnteredByPerson { get; set; }

        /// <summary>
        /// SCH.21 - Entered By Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> EnteredByPhoneNumber { get; set; }

        /// <summary>
        /// SCH.22 - Entered By Location.
        /// </summary>
        public PersonLocation EnteredByLocation { get; set; }

        /// <summary>
        /// SCH.23 - Parent Placer Appointment ID.
        /// </summary>
        public EntityIdentifier ParentPlacerAppointmentId { get; set; }

        /// <summary>
        /// SCH.24 - Parent Filler Appointment ID.
        /// </summary>
        public EntityIdentifier ParentFillerAppointmentId { get; set; }

        /// <summary>
        /// SCH.25 - Filler Status Code.
        /// <para>Suggested: 0278 Filler Status Codes -&gt; ClearHl7.Codes.V271.CodeFillerStatusCodes</para>
        /// </summary>
        public CodedWithExceptions FillerStatusCode { get; set; }

        /// <summary>
        /// SCH.26 - Placer Order Number.
        /// </summary>
        public IEnumerable<EntityIdentifier> PlacerOrderNumber { get; set; }

        /// <summary>
        /// SCH.27 - Filler Order Number.
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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            PlacerAppointmentId = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false) : null;
            FillerAppointmentId = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false) : null;
            OccurrenceNumber = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            PlacerGroupNumber = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[4], false) : null;
            ScheduleId = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[5], false) : null;
            EventReason = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[6], false) : null;
            AppointmentReason = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[7], false) : null;
            AppointmentType = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[8], false) : null;
            AppointmentDuration = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            AppointmentDurationUnits = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[10], false) : null;
            AppointmentTimingQuantity = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            PlacerContactPerson = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            PlacerContactPhoneNumber = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments[13], false) : null;
            PlacerContactAddress = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            PlacerContactLocation = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[15], false) : null;
            FillerContactPerson = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            FillerContactPhoneNumber = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments[17], false) : null;
            FillerContactAddress = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            FillerContactLocation = segments.Length > 19 && segments[19].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[19], false) : null;
            EnteredByPerson = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            EnteredByPhoneNumber = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            EnteredByLocation = segments.Length > 22 && segments[22].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[22], false) : null;
            ParentPlacerAppointmentId = segments.Length > 23 && segments[23].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[23], false) : null;
            ParentFillerAppointmentId = segments.Length > 24 && segments[24].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[24], false) : null;
            FillerStatusCode = segments.Length > 25 && segments[25].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[25], false) : null;
            PlacerOrderNumber = segments.Length > 26 && segments[26].Length > 0 ? segments[26].Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            FillerOrderNumber = segments.Length > 27 && segments[27].Length > 0 ? segments[27].Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 28, Configuration.FieldSeparator),
                                Id,
                                PlacerAppointmentId?.ToDelimitedString(),
                                FillerAppointmentId?.ToDelimitedString(),
                                OccurrenceNumber.HasValue ? OccurrenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                PlacerGroupNumber?.ToDelimitedString(),
                                ScheduleId?.ToDelimitedString(),
                                EventReason?.ToDelimitedString(),
                                AppointmentReason?.ToDelimitedString(),
                                AppointmentType?.ToDelimitedString(),
                                AppointmentDuration.HasValue ? AppointmentDuration.Value.ToString(Consts.NumericFormat, culture) : null,
                                AppointmentDurationUnits?.ToDelimitedString(),
                                AppointmentTimingQuantity,
                                PlacerContactPerson != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerContactPerson.Select(x => x.ToDelimitedString())) : null,
                                PlacerContactPhoneNumber?.ToDelimitedString(),
                                PlacerContactAddress != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerContactAddress.Select(x => x.ToDelimitedString())) : null,
                                PlacerContactLocation?.ToDelimitedString(),
                                FillerContactPerson != null ? string.Join(Configuration.FieldRepeatSeparator, FillerContactPerson.Select(x => x.ToDelimitedString())) : null,
                                FillerContactPhoneNumber?.ToDelimitedString(),
                                FillerContactAddress != null ? string.Join(Configuration.FieldRepeatSeparator, FillerContactAddress.Select(x => x.ToDelimitedString())) : null,
                                FillerContactLocation?.ToDelimitedString(),
                                EnteredByPerson != null ? string.Join(Configuration.FieldRepeatSeparator, EnteredByPerson.Select(x => x.ToDelimitedString())) : null,
                                EnteredByPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, EnteredByPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                EnteredByLocation?.ToDelimitedString(),
                                ParentPlacerAppointmentId?.ToDelimitedString(),
                                ParentFillerAppointmentId?.ToDelimitedString(),
                                FillerStatusCode?.ToDelimitedString(),
                                PlacerOrderNumber != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerOrderNumber.Select(x => x.ToDelimitedString())) : null,
                                FillerOrderNumber != null ? string.Join(Configuration.FieldRepeatSeparator, FillerOrderNumber.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}