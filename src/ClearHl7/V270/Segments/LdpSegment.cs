using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0264</remarks>
        public CodedWithExceptions LocationDepartment { get; set; }

        /// <summary>
        /// LDP.3 - Location Service.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0069</remarks>
        public IEnumerable<CodedWithExceptions> LocationService { get; set; }

        /// <summary>
        /// LDP.4 - Specialty Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0265</remarks>
        public IEnumerable<CodedWithExceptions> SpecialtyType { get; set; }

        /// <summary>
        /// LDP.5 - Valid Patient Classes.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0004</remarks>
        public IEnumerable<CodedWithExceptions> ValidPatientClasses { get; set; }

        /// <summary>
        /// LDP.6 - Active/Inactive Flag.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0183</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0267</remarks>
        public IEnumerable<VisitingHours> VisitingHours { get; set; }

        /// <summary>
        /// LDP.11 - Contact Phone.
        /// </summary>
        public ExtendedTelecommunicationNumber ContactPhone { get; set; }

        /// <summary>
        /// LDP.12 - Location Cost Center.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0462</remarks>
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