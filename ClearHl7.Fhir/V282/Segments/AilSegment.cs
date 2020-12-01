﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V282.Types;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AIL - Appointment Information - Location Resource.
    /// </summary>
    public class AilSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "AIL";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// AIL.1 - Set ID - AIL.
        /// </summary>
        public uint? SetIdAil { get; set; }

        /// <summary>
        /// AIL.2 - Segment Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0206</remarks>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// AIL.3 - Location Resource ID.
        /// </summary>
        public IEnumerable<PersonLocation> LocationResourceId { get; set; }

        /// <summary>
        /// AIL.4 - Location Type - AIL. { get; set; }
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0305</remarks>
        public CodedWithExceptions LocationTypeAil { get; set; }

        /// <summary>
        /// AIL.5 - Location Group.
        /// </summary>
        public CodedWithExceptions LocationGroup { get; set; }

        /// <summary>
        /// AIL.6 - Start Date/Time.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// AIL.7 - Start Date/Time Offset.
        /// </summary>
        public decimal? StartDateTimeOffset { get; set; }

        /// <summary>
        /// AIL.8 - Start Date/Time Offset Units.
        /// </summary>
        public CodedWithNoExceptions StartDateTimeOffsetUnits { get; set; }

        /// <summary>
        /// AIL.9 - Duration.
        /// </summary>
        public decimal? Duration { get; set; }

        /// <summary>
        /// AIL.10 - Duration Units.
        /// </summary>
        public CodedWithNoExceptions DurationUnits { get; set; }

        /// <summary>
        /// AIL.11 - Allow Substitution Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0279</remarks>
        public CodedWithExceptions AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIL.12 - Filler Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0278</remarks>
        public CodedWithExceptions FillerStatusCode { get; set; }

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
                                SetIdAil.HasValue ? SetIdAil.Value.ToString(culture) : null,
                                SegmentActionCode,
                                LocationResourceId != null ? string.Join(Configuration.FieldRepeatSeparator, LocationResourceId.Select(x => x.ToDelimitedString())) : null,
                                LocationTypeAil?.ToDelimitedString(),
                                LocationGroup?.ToDelimitedString(),
                                StartDateTime.HasValue ? StartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StartDateTimeOffset.HasValue ? StartDateTimeOffset.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartDateTimeOffsetUnits?.ToDelimitedString(),
                                Duration.HasValue ? Duration.Value.ToString(Consts.NumericFormat, culture) : null,
                                DurationUnits?.ToDelimitedString(),
                                AllowSubstitutionCode?.ToDelimitedString(),
                                FillerStatusCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}