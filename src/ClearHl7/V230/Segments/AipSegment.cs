﻿using System;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AIP - Appointment Information - Personnel Resource.
    /// </summary>
    public class AipSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "AIP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// AIP.1 - Set ID - AIP.
        /// </summary>
        public uint? SetIdAip { get; set; }

        /// <summary>
        /// AIP.2 - Segment Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0206</remarks>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// AIP.3 - Personnel Resource ID.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons PersonnelResourceId { get; set; }

        /// <summary>
        /// AIP.4 - Resource Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0182</remarks>
        public CodedElement ResourceType { get; set; }

        /// <summary>
        /// AIP.5 - Resource Group.
        /// </summary>
        public CodedElement ResourceGroup { get; set; }

        /// <summary>
        /// AIP.6 - Start Date/Time.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// AIP.7 - Start Date/Time Offset.
        /// </summary>
        public decimal? StartDateTimeOffset { get; set; }

        /// <summary>
        /// AIP.8 - Start Date/Time Offset Units.
        /// </summary>
        public CodedElement StartDateTimeOffsetUnits { get; set; }

        /// <summary>
        /// AIP.9 - Duration.
        /// </summary>
        public decimal? Duration { get; set; }

        /// <summary>
        /// AIP.10 - Duration Units.
        /// </summary>
        public CodedElement DurationUnits { get; set; }

        /// <summary>
        /// AIP.11 - Allow Substitution Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0279</remarks>
        public string AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIP.12 - Filler Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0278</remarks>
        public CodedElement FillerStatusCode { get; set; }

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
                                SetIdAip.HasValue ? SetIdAip.Value.ToString(culture) : null,
                                SegmentActionCode,
                                PersonnelResourceId?.ToDelimitedString(),
                                ResourceType?.ToDelimitedString(),
                                ResourceGroup?.ToDelimitedString(),
                                StartDateTime.HasValue ? StartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StartDateTimeOffset.HasValue ? StartDateTimeOffset.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartDateTimeOffsetUnits?.ToDelimitedString(),
                                Duration.HasValue ? Duration.Value.ToString(Consts.NumericFormat, culture) : null,
                                DurationUnits?.ToDelimitedString(),
                                AllowSubstitutionCode,
                                FillerStatusCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}