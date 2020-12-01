using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V282.Types;

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

        /// <summary>
        /// PRT.1 - Participation Instance ID.
        /// </summary>
        public EntityIdentifier ParticipationInstanceId { get; set; }

        /// <summary>
        /// PRT.2 - Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0206</remarks>
        public string ActionCode { get; set; }

        /// <summary>
        /// PRT.3 - Action Reason.
        /// </summary>
        public CodedWithExceptions ActionReason { get; set; }

        /// <summary>
        /// PRT.4 - Participation.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0912</remarks>
        public CodedWithExceptions Participation { get; set; }

        /// <summary>
        /// PRT.5 - Participation Person.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ParticipationPerson { get; set; }

        /// <summary>
        /// PRT.6 - Participation Person Provider Type.
        /// </summary>
        public CodedWithExceptions ParticipationPersonProviderType { get; set; }

        /// <summary>
        /// PRT.7 - Participant Organization Unit Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0406</remarks>
        public CodedWithExceptions ParticipantOrganizationUnitType { get; set; }

        /// <summary>
        /// PRT.8 - Participation Organization.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> ParticipationOrganization { get; set; }

        /// <summary>
        /// PRT.9 - Participant Location.
        /// </summary>
        public IEnumerable<PersonLocation> ParticipantLocation { get; set; }

        /// <summary>
        /// PRT.10 - Participation Device.
        /// </summary>
        public IEnumerable<EntityIdentifier> ParticipationDevice { get; set; }

        /// <summary>
        /// PRT.11 - Participation Begin Date/Time (arrival time).
        /// </summary>
        public DateTime? ParticipationBeginDateTimeArrivalTime { get; set; }

        /// <summary>
        /// PRT.12 - Participation End Date/Time (departure time).
        /// </summary>
        public DateTime? ParticipationEndDateTimeDepartureTime { get; set; }

        /// <summary>
        /// PRT.13 - Participation Qualitative Duration.
        /// </summary>
        public CodedWithExceptions ParticipationQualitativeDuration { get; set; }

        /// <summary>
        /// PRT.14 - Participation Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> ParticipationAddress { get; set; }

        /// <summary>
        /// PRT.15 - Participant Telecommunication Address.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> ParticipantTelecommunicationAddress { get; set; }

        /// <summary>
        /// PRT.16 - Participant Device Identifier.
        /// </summary>
        public EntityIdentifier ParticipantDeviceIdentifier { get; set; }

        /// <summary>
        /// PRT.17 - Participant Device Manufacture Date.
        /// </summary>
        public DateTime? ParticipantDeviceManufactureDate { get; set; }

        /// <summary>
        /// PRT.18 - Participant Device Expiry Date.
        /// </summary>
        public DateTime? ParticipantDeviceExpiryDate { get; set; }

        /// <summary>
        /// PRT.19 - Participant Device Lot Number.
        /// </summary>
        public string ParticipantDeviceLotNumber { get; set; }

        /// <summary>
        /// PRT.20 - Participant Device Serial Number.
        /// </summary>
        public string ParticipantDeviceSerialNumber { get; set; }

        /// <summary>
        /// PRT.21 - Participant Device Donation Identification.
        /// </summary>
        public EntityIdentifier ParticipantDeviceDonationIdentification { get; set; }

        /// <summary>
        /// PRT.22 - Participation Device Type.
        /// </summary>
        public CodedWithNoExceptions ParticipationDeviceType { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 23, Configuration.FieldSeparator),
                                Id,
                                ParticipationInstanceId?.ToDelimitedString(),
                                ActionCode,
                                ActionReason?.ToDelimitedString(),
                                Participation?.ToDelimitedString(),
                                ParticipationPerson != null ? string.Join(Configuration.FieldRepeatSeparator, ParticipationPerson.Select(x => x.ToDelimitedString())) : null,
                                ParticipationPersonProviderType?.ToDelimitedString(),
                                ParticipantOrganizationUnitType?.ToDelimitedString(),
                                ParticipationOrganization != null ? string.Join(Configuration.FieldRepeatSeparator, ParticipationOrganization.Select(x => x.ToDelimitedString())) : null,
                                ParticipantLocation != null ? string.Join(Configuration.FieldRepeatSeparator, ParticipantLocation.Select(x => x.ToDelimitedString())) : null,
                                ParticipationDevice != null ? string.Join(Configuration.FieldRepeatSeparator, ParticipationDevice.Select(x => x.ToDelimitedString())) : null,
                                ParticipationBeginDateTimeArrivalTime.HasValue ? ParticipationBeginDateTimeArrivalTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ParticipationEndDateTimeDepartureTime.HasValue ? ParticipationEndDateTimeDepartureTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ParticipationQualitativeDuration?.ToDelimitedString(),
                                ParticipationAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ParticipationAddress.Select(x => x.ToDelimitedString())) : null,
                                ParticipantTelecommunicationAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ParticipantTelecommunicationAddress.Select(x => x.ToDelimitedString())) : null,
                                ParticipantDeviceIdentifier?.ToDelimitedString(),
                                ParticipantDeviceManufactureDate.HasValue ? ParticipantDeviceManufactureDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ParticipantDeviceExpiryDate.HasValue ? ParticipantDeviceExpiryDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ParticipantDeviceLotNumber,
                                ParticipantDeviceSerialNumber,
                                ParticipantDeviceDonationIdentification?.ToDelimitedString(),
                                ParticipationDeviceType?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}