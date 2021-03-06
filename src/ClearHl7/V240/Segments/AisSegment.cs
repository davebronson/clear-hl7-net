﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AIS - Appointment Information.
    /// </summary>
    public class AisSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "AIS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// AIS.1 - Set ID - AIS.
        /// </summary>
        public uint? SetIdAis { get; set; }

        /// <summary>
        /// AIS.2 - Segment Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V240.CodeSegmentActionCode</para>
        /// </summary>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// AIS.3 - Universal Service Identifier.
        /// </summary>
        public CodedElement UniversalServiceIdentifier { get; set; }

        /// <summary>
        /// AIS.4 - Start Date/Time.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// AIS.5 - Start Date/Time Offset.
        /// </summary>
        public decimal? StartDateTimeOffset { get; set; }

        /// <summary>
        /// AIS.6 - Start Date/Time Offset Units.
        /// </summary>
        public CodedElement StartDateTimeOffsetUnits { get; set; }

        /// <summary>
        /// AIS.7 - Duration.
        /// </summary>
        public decimal? Duration { get; set; }

        /// <summary>
        /// AIS.8 - Duration Units.
        /// </summary>
        public CodedElement DurationUnits { get; set; }

        /// <summary>
        /// AIS.9 - Allow Substitution Code.
        /// <para>Suggested: 0279 Allow Substitution Codes -&gt; ClearHl7.Codes.V240.CodeAllowSubstitutionCodes</para>
        /// </summary>
        public string AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIS.10 - Filler Status Code.
        /// <para>Suggested: 0278 Filler Status Codes -&gt; ClearHl7.Codes.V240.CodeFillerStatusCodes</para>
        /// </summary>
        public CodedElement FillerStatusCode { get; set; }

        /// <summary>
        /// AIS.11 - Placer Supplemental Service Information.
        /// <para>Suggested: 0411 Supplemental Service Information Values</para>
        /// </summary>
        public IEnumerable<CodedElement> PlacerSupplementalServiceInformation { get; set; }

        /// <summary>
        /// AIS.12 - Filler Supplemental Service Information.
        /// <para>Suggested: 0411 Supplemental Service Information Values</para>
        /// </summary>
        public IEnumerable<CodedElement> FillerSupplementalServiceInformation { get; set; }

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
                                SetIdAis.HasValue ? SetIdAis.Value.ToString(culture) : null,
                                SegmentActionCode,
                                UniversalServiceIdentifier?.ToDelimitedString(),
                                StartDateTime.HasValue ? StartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StartDateTimeOffset.HasValue ? StartDateTimeOffset.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartDateTimeOffsetUnits?.ToDelimitedString(),
                                Duration.HasValue ? Duration.Value.ToString(Consts.NumericFormat, culture) : null,
                                DurationUnits?.ToDelimitedString(),
                                AllowSubstitutionCode,
                                FillerStatusCode?.ToDelimitedString(),
                                PlacerSupplementalServiceInformation != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerSupplementalServiceInformation.Select(x => x.ToDelimitedString())) : null,
                                FillerSupplementalServiceInformation != null ? string.Join(Configuration.FieldRepeatSeparator, FillerSupplementalServiceInformation.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}