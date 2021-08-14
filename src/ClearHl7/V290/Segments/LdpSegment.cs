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
    /// HL7 Version 2 Segment LDP - Location Department.
    /// </summary>
    public class LdpSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "LDP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// LDP.1 - Primary Key Value - LDP.
        /// </summary>
        public PersonLocation PrimaryKeyValueLdp { get; set; }

        /// <summary>
        /// LDP.2 - Location Department.
        /// <para>Suggested: 0264 Location Department</para>
        /// </summary>
        public CodedWithExceptions LocationDepartment { get; set; }

        /// <summary>
        /// LDP.3 - Location Service.
        /// <para>Suggested: 0069 Hospital Service -&gt; ClearHl7.Codes.V290.CodeHospitalService</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LocationService { get; set; }

        /// <summary>
        /// LDP.4 - Specialty Type.
        /// <para>Suggested: 0265 Specialty Type -&gt; ClearHl7.Codes.V290.CodeSpecialtyType</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecialtyType { get; set; }

        /// <summary>
        /// LDP.5 - Valid Patient Classes.
        /// <para>Suggested: 0004 Patient Class -&gt; ClearHl7.Codes.V290.CodePatientClass</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ValidPatientClasses { get; set; }

        /// <summary>
        /// LDP.6 - Active/Inactive Flag.
        /// <para>Suggested: 0183 Active/Inactive -&gt; ClearHl7.Codes.V290.CodeActiveInactive</para>
        /// </summary>
        public string ActiveInactiveFlag { get; set; }

        /// <summary>
        /// LDP.7 - Activation Date - LDP.
        /// </summary>
        public DateTime? ActivationDateLdp { get; set; }

        /// <summary>
        /// LDP.8 - Inactivation Date - LDP.
        /// </summary>
        public DateTime? InactivationDateLdp { get; set; }

        /// <summary>
        /// LDP.9 - Inactivated Reason.
        /// </summary>
        public string InactivatedReason { get; set; }

        /// <summary>
        /// LDP.10 - Visiting Hours.
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Codes.V290.CodeDaysOfTheWeek</para>
        /// </summary>
        public IEnumerable<VisitingHours> VisitingHours { get; set; }

        /// <summary>
        /// LDP.11 - Contact Phone.
        /// </summary>
        public ExtendedTelecommunicationNumber ContactPhone { get; set; }

        /// <summary>
        /// LDP.12 - Location Cost Center.
        /// <para>Suggested: 0462 Location Cost Center</para>
        /// </summary>
        public CodedWithExceptions LocationCostCenter { get; set; }

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

            PrimaryKeyValueLdp = segments.Length > 1 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(1), false) : null;
            LocationDepartment = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            LocationService = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            SpecialtyType = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ValidPatientClasses = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ActiveInactiveFlag = segments.ElementAtOrDefault(6);
            ActivationDateLdp = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            InactivationDateLdp = segments.ElementAtOrDefault(8)?.ToNullableDateTime();
            InactivatedReason = segments.ElementAtOrDefault(9);
            VisitingHours = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => TypeHelper.Deserialize<VisitingHours>(x, false)) : null;
            ContactPhone = segments.Length > 11 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments.ElementAtOrDefault(11), false) : null;
            LocationCostCenter = segments.Length > 12 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(12), false) : null;
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
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueLdp?.ToDelimitedString(),
                                LocationDepartment?.ToDelimitedString(),
                                LocationService != null ? string.Join(Configuration.FieldRepeatSeparator, LocationService.Select(x => x.ToDelimitedString())) : null,
                                SpecialtyType != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialtyType.Select(x => x.ToDelimitedString())) : null,
                                ValidPatientClasses != null ? string.Join(Configuration.FieldRepeatSeparator, ValidPatientClasses.Select(x => x.ToDelimitedString())) : null,
                                ActiveInactiveFlag,
                                ActivationDateLdp.HasValue ? ActivationDateLdp.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InactivationDateLdp.HasValue ? InactivationDateLdp.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InactivatedReason,
                                VisitingHours != null ? string.Join(Configuration.FieldRepeatSeparator, VisitingHours.Select(x => x.ToDelimitedString())) : null,
                                ContactPhone?.ToDelimitedString(),
                                LocationCostCenter?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}