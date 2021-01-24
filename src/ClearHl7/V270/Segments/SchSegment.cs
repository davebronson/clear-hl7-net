using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0276</remarks>
        public CodedWithExceptions AppointmentReason { get; set; }

        /// <summary>
        /// SCH.8 - Appointment Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0277</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0278</remarks>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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