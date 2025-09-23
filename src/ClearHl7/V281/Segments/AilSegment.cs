using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AIL - Appointment Information - Location Resource.
    /// </summary>
    public class AilSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AilSegment"/> class.
        /// </summary>
        public AilSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AilSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public AilSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "AIL";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// AIL.1 - Set ID - AIL.
        /// </summary>
        public uint? SetIdAil { get; set; }

        /// <summary>
        /// AIL.2 - Segment Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V281.CodeSegmentActionCode</para>
        /// </summary>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// AIL.3 - Location Resource ID.
        /// </summary>
        public IEnumerable<PersonLocation> LocationResourceId { get; set; }

        /// <summary>
        /// AIL.4 - Location Type - AIL.
        /// <para>Suggested: 0305 Person Location Type -&gt; ClearHl7.Codes.V281.CodePersonLocationType</para>
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
        /// <para>Suggested: 0279 Allow Substitution Codes -&gt; ClearHl7.Codes.V281.CodeAllowSubstitutionCodes</para>
        /// </summary>
        public CodedWithExceptions AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIL.12 - Filler Status Code.
        /// <para>Suggested: 0278 Filler Status Codes -&gt; ClearHl7.Codes.V281.CodeFillerStatusCodes</para>
        /// </summary>
        public CodedWithExceptions FillerStatusCode { get; set; }

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

            SetIdAil = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            SegmentActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            LocationResourceId = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<PersonLocation>(x, false, seps)) : null;
            LocationTypeAil = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            LocationGroup = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            StartDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            StartDateTimeOffset = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            StartDateTimeOffsetUnits = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[8], false, seps) : null;
            Duration = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            DurationUnits = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[10], false, seps) : null;
            AllowSubstitutionCode = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[11], false, seps) : null;
            FillerStatusCode = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[12], false, seps) : null;
        }

        /// <inheritdoc/>
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
                                StartDateTime.ToHl7DateTimeString(typeof(AilSegment), nameof(StartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
