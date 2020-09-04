using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PRT - Participation Information.
    /// </summary>
    public class PrtSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PRT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PRT.1 - Participation Instance ID.
        ///// </summary>
        //public ParticipationInstanceId { get; set; }

        ///// <summary>
        ///// PRT.2 - Action Code.
        ///// </summary>
        //public ActionCode { get; set; }

        ///// <summary>
        ///// PRT.3 - Action Reason.
        ///// </summary>
        //public ActionReason { get; set; }

        ///// <summary>
        ///// PRT.4 - Participation.
        ///// </summary>
        //public Participation { get; set; }

        ///// <summary>
        ///// PRT.5 - Participation Person.
        ///// </summary>
        //public ParticipationPerson { get; set; }

        ///// <summary>
        ///// PRT.6 - Participation Person Provider Type.
        ///// </summary>
        //public ParticipationPersonProviderType { get; set; }

        ///// <summary>
        ///// PRT.7 - Participant Organization Unit Type.
        ///// </summary>
        //public ParticipantOrganizationUnitType { get; set; }

        ///// <summary>
        ///// PRT.8 - Participation Organization.
        ///// </summary>
        //public ParticipationOrganization { get; set; }

        ///// <summary>
        ///// PRT.9 - Participant Location.
        ///// </summary>
        //public ParticipantLocation { get; set; }

        ///// <summary>
        ///// PRT.10 - Participation Device.
        ///// </summary>
        //public ParticipationDevice { get; set; }

        ///// <summary>
        ///// PRT.11 - Participation Begin Date/Time (arrival time).
        ///// </summary>
        //public ParticipationBeginDateTimeArrivalTime { get; set; }

        ///// <summary>
        ///// PRT.12 - Participation End Date/Time (departure time).
        ///// </summary>
        //public ParticipationEndDateTimeDepartureTime { get; set; }

        ///// <summary>
        ///// PRT.13 - Participation Qualitative Duration.
        ///// </summary>
        //public ParticipationQualitativeDuration { get; set; }

        ///// <summary>
        ///// PRT.14 - Participation Address.
        ///// </summary>
        //public ParticipationAddress { get; set; }

        ///// <summary>
        ///// PRT.15 - Participant Telecommunication Address.
        ///// </summary>
        //public ParticipantTelecommunicationAddress { get; set; }

        ///// <summary>
        ///// PRT.16 - Participant Device Identifier.
        ///// </summary>
        //public ParticipantDeviceIdentifier { get; set; }

        ///// <summary>
        ///// PRT.17 - Participant Device Manufacture Date.
        ///// </summary>
        //public ParticipantDeviceManufactureDate { get; set; }

        ///// <summary>
        ///// PRT.18 - Participant Device Expiry Date.
        ///// </summary>
        //public ParticipantDeviceExpiryDate { get; set; }

        ///// <summary>
        ///// PRT.19 - Participant Device Lot Number.
        ///// </summary>
        //public ParticipantDeviceLotNumber { get; set; }

        ///// <summary>
        ///// PRT.20 - Participant Device Serial Number.
        ///// </summary>
        //public ParticipantDeviceSerialNumber { get; set; }

        ///// <summary>
        ///// PRT.21 - Participant Device Donation Identification.
        ///// </summary>
        //public ParticipantDeviceDonationIdentification { get; set; }

        ///// <summary>
        ///// PRT.22 - Participation Device Type.
        ///// </summary>
        //public ParticipationDeviceType { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}"
                                ).TrimEnd('|');
        }
    }
}