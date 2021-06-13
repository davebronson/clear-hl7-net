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
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V290.CodeSegmentActionCode</para>
        /// </summary>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// AIL.3 - Location Resource ID.
        /// </summary>
        public IEnumerable<PersonLocation> LocationResourceId { get; set; }

        /// <summary>
        /// AIL.4 - Location Type - AIL.
        /// <para>Suggested: 0305 Person Location Type -&gt; ClearHl7.Codes.V290.CodePersonLocationType</para>
        /// </summary>
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
        /// <para>Suggested: 0279 Allow Substitution Codes -&gt; ClearHl7.Codes.V290.CodeAllowSubstitutionCodes</para>
        /// </summary>
        public CodedWithExceptions AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIL.12 - Filler Status Code.
        /// <para>Suggested: 0278 Filler Status Codes -&gt; ClearHl7.Codes.V290.CodeFillerStatusCodes</para>
        /// </summary>
        public CodedWithExceptions FillerStatusCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public AilSegment FromDelimitedString(string delimitedString)
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

            SetIdAil = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            SegmentActionCode = segments.ElementAtOrDefault(2);
            LocationResourceId = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => new PersonLocation().FromDelimitedString(x)) : null;
            LocationTypeAil = segments.Length > 4 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            LocationGroup = segments.Length > 5 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            StartDateTime = segments.ElementAtOrDefault(6)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            StartDateTimeOffset = segments.ElementAtOrDefault(7)?.ToNullableDecimal();
            StartDateTimeOffsetUnits = segments.Length > 8 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            Duration = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            DurationUnits = segments.Length > 10 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            AllowSubstitutionCode = segments.Length > 11 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            FillerStatusCode = segments.Length > 12 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(12)) : null;

            return this;
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