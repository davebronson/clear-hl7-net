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
        /// <para>Suggested: 0287 Problem/Goal Action Code -&gt; ClearHl7.Codes.V271.CodeProblemGoalActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// PRT.3 - Action Reason.
        /// </summary>
        public CodedWithExceptions ActionReason { get; set; }

        /// <summary>
        /// PRT.4 - Participation.
        /// <para>Suggested: 0912 Participation -&gt; ClearHl7.Codes.V271.CodeParticipation</para>
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
        /// <para>Suggested: 0406 Participant Organization Unit Type -&gt; ClearHl7.Codes.V271.CodeParticipantOrganizationUnitType</para>
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

            ParticipationInstanceId = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            ActionCode = segments.ElementAtOrDefault(2);
            ActionReason = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            Participation = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            ParticipationPerson = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            ParticipationPersonProviderType = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(6), false) : null;
            ParticipantOrganizationUnitType = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), false) : null;
            ParticipationOrganization = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            ParticipantLocation = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<PersonLocation>(x, false)) : null;
            ParticipationDevice = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            ParticipationBeginDateTimeArrivalTime = segments.ElementAtOrDefault(11)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ParticipationEndDateTimeDepartureTime = segments.ElementAtOrDefault(12)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ParticipationQualitativeDuration = segments.Length > 13 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(13), false) : null;
            ParticipationAddress = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            ParticipantTelecommunicationAddress = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 16, Configuration.FieldSeparator),
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
                                ParticipantTelecommunicationAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ParticipantTelecommunicationAddress.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}