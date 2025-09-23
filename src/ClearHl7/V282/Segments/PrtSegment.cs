using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PRT - Participation Information.
    /// </summary>
    public class PrtSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrtSegment"/> class.
        /// </summary>
        public PrtSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrtSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PrtSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PRT";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PRT.1 - Participation Instance ID.
        /// </summary>
        public EntityIdentifier ParticipationInstanceId { get; set; }

        /// <summary>
        /// PRT.2 - Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V282.CodeSegmentActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// PRT.3 - Action Reason.
        /// </summary>
        public CodedWithExceptions ActionReason { get; set; }

        /// <summary>
        /// PRT.4 - Participation.
        /// <para>Suggested: 0912 Participation -&gt; ClearHl7.Codes.V282.CodeParticipation</para>
        /// </summary>
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
        /// <para>Suggested: 0406 Participant Organization Unit Type -&gt; ClearHl7.Codes.V282.CodeParticipantOrganizationUnitType</para>
        /// </summary>
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

            ParticipationInstanceId = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            ActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ActionReason = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            Participation = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            ParticipationPerson = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            ParticipationPersonProviderType = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            ParticipantOrganizationUnitType = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            ParticipationOrganization = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            ParticipantLocation = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<PersonLocation>(x, false, seps)) : null;
            ParticipationDevice = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            ParticipationBeginDateTimeArrivalTime = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDateTime() : null;
            ParticipationEndDateTimeDepartureTime = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            ParticipationQualitativeDuration = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[13], false, seps) : null;
            ParticipationAddress = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            ParticipantTelecommunicationAddress = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            ParticipantDeviceIdentifier = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[16], false, seps) : null;
            ParticipantDeviceManufactureDate = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDateTime() : null;
            ParticipantDeviceExpiryDate = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDateTime() : null;
            ParticipantDeviceLotNumber = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            ParticipantDeviceSerialNumber = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            ParticipantDeviceDonationIdentification = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[21], false, seps) : null;
            ParticipationDeviceType = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[22], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
                                ParticipationBeginDateTimeArrivalTime.ToHl7DateTimeString(typeof(PrtSegment), nameof(ParticipationBeginDateTimeArrivalTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ParticipationEndDateTimeDepartureTime.ToHl7DateTimeString(typeof(PrtSegment), nameof(ParticipationEndDateTimeDepartureTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ParticipationQualitativeDuration?.ToDelimitedString(),
                                ParticipationAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ParticipationAddress.Select(x => x.ToDelimitedString())) : null,
                                ParticipantTelecommunicationAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ParticipantTelecommunicationAddress.Select(x => x.ToDelimitedString())) : null,
                                ParticipantDeviceIdentifier?.ToDelimitedString(),
                                ParticipantDeviceManufactureDate.ToHl7DateTimeString(typeof(PrtSegment), nameof(ParticipantDeviceManufactureDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ParticipantDeviceExpiryDate.ToHl7DateTimeString(typeof(PrtSegment), nameof(ParticipantDeviceExpiryDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ParticipantDeviceLotNumber,
                                ParticipantDeviceSerialNumber,
                                ParticipantDeviceDonationIdentification?.ToDelimitedString(),
                                ParticipationDeviceType?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
