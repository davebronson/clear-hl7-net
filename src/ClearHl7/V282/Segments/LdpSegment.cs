﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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
        /// <para>Suggested: 0069 Hospital Service -&gt; ClearHl7.Fhir.Codes.V282.CodeHospitalService</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LocationService { get; set; }

        /// <summary>
        /// LDP.4 - Specialty Type.
        /// <para>Suggested: 0265 Specialty Type -&gt; ClearHl7.Fhir.Codes.V282.CodeSpecialtyType</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecialtyType { get; set; }

        /// <summary>
        /// LDP.5 - Valid Patient Classes.
        /// <para>Suggested: 0004 Patient Class  -&gt; ClearHl7.Fhir.Codes.V282.CodePatientClass</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ValidPatientClasses { get; set; }

        /// <summary>
        /// LDP.6 - Active/Inactive Flag.
        /// <para>Suggested: 0183 Active/Inactive -&gt; ClearHl7.Fhir.Codes.V282.CodeActiveInactive</para>
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
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Fhir.Codes.V282.CodeDaysOfTheWeek</para>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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