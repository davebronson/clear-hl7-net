using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        public EntityIdentifierPair PlacerGroupNumber { get; set; }

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
        /// <para>Suggested: 0276 Appointment Reason Codes -&gt; ClearHl7.Codes.V290.CodeAppointmentReasonCodes</para>
        /// </summary>
        public CodedWithExceptions AppointmentReason { get; set; }

        /// <summary>
        /// SCH.8 - Appointment Type.
        /// <para>Suggested: 0277 Appointment Type Codes -&gt; ClearHl7.Codes.V290.CodeAppointmentTypeCodes</para>
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
        /// <para>Suggested: 0278 Filler Status Codes -&gt; ClearHl7.Codes.V290.CodeFillerStatusCodes</para>
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
        /// SCH.28 - Alternate Placer Order Group Number.
        /// </summary>
        public EntityIdentifierPair AlternatePlacerOrderGroupNumber { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public SchSegment FromDelimitedString(string delimitedString)
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

            PlacerAppointmentId = segments.Length > 1 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            FillerAppointmentId = segments.Length > 2 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            OccurrenceNumber = segments.ElementAtOrDefault(3)?.ToNullableDecimal();
            PlacerGroupNumber = segments.Length > 4 ? new EntityIdentifierPair().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            ScheduleId = segments.Length > 5 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            EventReason = segments.Length > 6 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            AppointmentReason = segments.Length > 7 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            AppointmentType = segments.Length > 8 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            AppointmentDuration = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            AppointmentDurationUnits = segments.Length > 10 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            AppointmentTimingQuantity = segments.ElementAtOrDefault(11);
            PlacerContactPerson = segments.Length > 12 ? segments.ElementAtOrDefault(12).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            PlacerContactPhoneNumber = segments.Length > 13 ? new ExtendedTelecommunicationNumber().FromDelimitedString(segments.ElementAtOrDefault(13)) : null;
            PlacerContactAddress = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => new ExtendedAddress().FromDelimitedString(x)) : null;
            PlacerContactLocation = segments.Length > 15 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(15)) : null;
            FillerContactPerson = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            FillerContactPhoneNumber = segments.Length > 17 ? new ExtendedTelecommunicationNumber().FromDelimitedString(segments.ElementAtOrDefault(17)) : null;
            FillerContactAddress = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => new ExtendedAddress().FromDelimitedString(x)) : null;
            FillerContactLocation = segments.Length > 19 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(19)) : null;
            EnteredByPerson = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            EnteredByPhoneNumber = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            EnteredByLocation = segments.Length > 22 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(22)) : null;
            ParentPlacerAppointmentId = segments.Length > 23 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(23)) : null;
            ParentFillerAppointmentId = segments.Length > 24 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(24)) : null;
            FillerStatusCode = segments.Length > 25 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(25)) : null;
            PlacerOrderNumber = segments.Length > 26 ? segments.ElementAtOrDefault(26).Split(separator).Select(x => new EntityIdentifier().FromDelimitedString(x)) : null;
            FillerOrderNumber = segments.Length > 27 ? segments.ElementAtOrDefault(27).Split(separator).Select(x => new EntityIdentifier().FromDelimitedString(x)) : null;
            AlternatePlacerOrderGroupNumber = segments.Length > 28 ? new EntityIdentifierPair().FromDelimitedString(segments.ElementAtOrDefault(28)) : null;
            
            return this;
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
                                StringHelper.StringFormatSequence(0, 29, Configuration.FieldSeparator),
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
                                FillerOrderNumber != null ? string.Join(Configuration.FieldRepeatSeparator, FillerOrderNumber.Select(x => x.ToDelimitedString())) : null,
                                AlternatePlacerOrderGroupNumber?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}