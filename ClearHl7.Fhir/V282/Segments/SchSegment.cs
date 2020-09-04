using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// SCH.1 - Placer Appointment ID.
        ///// </summary>
        //public PlacerAppointmentId { get; set; }

        ///// <summary>
        ///// SCH.2 - Filler Appointment ID.
        ///// </summary>
        //public FillerAppointmentId { get; set; }

        ///// <summary>
        ///// SCH.3 - Occurrence Number.
        ///// </summary>
        //public OccurrenceNumber { get; set; }

        ///// <summary>
        ///// SCH.4 - Placer Group Number.
        ///// </summary>
        //public PlacerGroupNumber { get; set; }

        ///// <summary>
        ///// SCH.5 - Schedule ID.
        ///// </summary>
        //public ScheduleId { get; set; }

        ///// <summary>
        ///// SCH.6 - Event Reason.
        ///// </summary>
        //public EventReason { get; set; }

        ///// <summary>
        ///// SCH.7 - Appointment Reason.
        ///// </summary>
        //public AppointmentReason { get; set; }

        ///// <summary>
        ///// SCH.8 - Appointment Type.
        ///// </summary>
        //public AppointmentType { get; set; }

        ///// <summary>
        ///// SCH.9 - Appointment Duration.
        ///// </summary>
        //public AppointmentDuration { get; set; }

        ///// <summary>
        ///// SCH.10 - Appointment Duration Units.
        ///// </summary>
        //public AppointmentDurationUnits { get; set; }

        ///// <summary>
        ///// SCH.11 - Appointment Timing Quantity.
        ///// </summary>
        //public AppointmentTimingQuantity { get; set; }

        ///// <summary>
        ///// SCH.12 - Placer Contact Person.
        ///// </summary>
        //public PlacerContactPerson { get; set; }

        ///// <summary>
        ///// SCH.13 - Placer Contact Phone Number.
        ///// </summary>
        //public PlacerContactPhoneNumber { get; set; }

        ///// <summary>
        ///// SCH.14 - Placer Contact Address.
        ///// </summary>
        //public PlacerContactAddress { get; set; }

        ///// <summary>
        ///// SCH.15 - Placer Contact Location.
        ///// </summary>
        //public PlacerContactLocation { get; set; }

        ///// <summary>
        ///// SCH.16 - Filler Contact Person.
        ///// </summary>
        //public FillerContactPerson { get; set; }

        ///// <summary>
        ///// SCH.17 - Filler Contact Phone Number.
        ///// </summary>
        //public FillerContactPhoneNumber { get; set; }

        ///// <summary>
        ///// SCH.18 - Filler Contact Address.
        ///// </summary>
        //public FillerContactAddress { get; set; }

        ///// <summary>
        ///// SCH.19 - Filler Contact Location.
        ///// </summary>
        //public FillerContactLocation { get; set; }

        ///// <summary>
        ///// SCH.20 - Entered By Person.
        ///// </summary>
        //public EnteredByPerson { get; set; }

        ///// <summary>
        ///// SCH.21 - Entered By Phone Number.
        ///// </summary>
        //public EnteredByPhoneNumber { get; set; }

        ///// <summary>
        ///// SCH.22 - Entered By Location.
        ///// </summary>
        //public EnteredByLocation { get; set; }

        ///// <summary>
        ///// SCH.23 - Parent Placer Appointment ID.
        ///// </summary>
        //public ParentPlacerAppointmentId { get; set; }

        ///// <summary>
        ///// SCH.24 - Parent Filler Appointment ID.
        ///// </summary>
        //public ParentFillerAppointmentId { get; set; }

        ///// <summary>
        ///// SCH.25 - Filler Status Code.
        ///// </summary>
        //public FillerStatusCode { get; set; }

        ///// <summary>
        ///// SCH.26 - Placer Order Number.
        ///// </summary>
        //public PlacerOrderNumber { get; set; }

        ///// <summary>
        ///// SCH.27 - Filler Order Number.
        ///// </summary>
        //public FillerOrderNumber { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}"
                                ).TrimEnd('|');
        }
    }
}