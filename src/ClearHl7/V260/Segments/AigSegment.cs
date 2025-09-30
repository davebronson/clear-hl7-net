using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AIG - Appointment Information - General Resource.
    /// </summary>
    public class AigSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AigSegment"/> class.
        /// </summary>
        public AigSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AigSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public AigSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "AIG";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// AIG.1 - Set ID - AIG.
        /// </summary>
        public uint? SetIdAig { get; set; }

        /// <summary>
        /// AIG.2 - Segment Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V260.CodeSegmentActionCode</para>
        /// </summary>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// AIG.3 - Resource ID.
        /// </summary>
        public CodedWithExceptions ResourceId { get; set; }

        /// <summary>
        /// AIG.4 - Resource Type.
        /// </summary>
        public CodedWithExceptions ResourceType { get; set; }

        /// <summary>
        /// AIG.5 - Resource Group.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ResourceGroup { get; set; }

        /// <summary>
        /// AIG.6 - Resource Quantity.
        /// </summary>
        public decimal? ResourceQuantity { get; set; }

        /// <summary>
        /// AIG.7 - Resource Quantity Units.
        /// </summary>
        public CodedWithNoExceptions ResourceQuantityUnits { get; set; }

        /// <summary>
        /// AIG.8 - Start Date/Time.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// AIG.9 - Start Date/Time Offset.
        /// </summary>
        public decimal? StartDateTimeOffset { get; set; }

        /// <summary>
        /// AIG.10 - Start Date/Time Offset Units.
        /// </summary>
        public CodedWithNoExceptions StartDateTimeOffsetUnits { get; set; }

        /// <summary>
        /// AIG.11 - Duration.
        /// </summary>
        public decimal? Duration { get; set; }

        /// <summary>
        /// AIG.12 - Duration Units.
        /// </summary>
        public CodedWithNoExceptions DurationUnits { get; set; }

        /// <summary>
        /// AIG.13 - Allow Substitution Code.
        /// <para>Suggested: 0279 Allow Substitution Codes -&gt; ClearHl7.Codes.V260.CodeAllowSubstitutionCodes</para>
        /// </summary>
        public string AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIG.14 - Filler Status Code.
        /// <para>Suggested: 0278 Filler Status Codes -&gt; ClearHl7.Codes.V260.CodeFillerStatusCodes</para>
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

            SetIdAig = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            SegmentActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ResourceId = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            ResourceType = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            ResourceGroup = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ResourceQuantity = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            ResourceQuantityUnits = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[7], false, seps) : null;
            StartDateTime = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            StartDateTimeOffset = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            StartDateTimeOffsetUnits = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[10], false, seps) : null;
            Duration = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDecimal() : null;
            DurationUnits = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[12], false, seps) : null;
            AllowSubstitutionCode = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            FillerStatusCode = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[14], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                SetIdAig.HasValue ? SetIdAig.Value.ToString(culture) : null,
                                SegmentActionCode,
                                ResourceId?.ToDelimitedString(),
                                ResourceType?.ToDelimitedString(),
                                ResourceGroup != null ? string.Join(Configuration.FieldRepeatSeparator, ResourceGroup.Select(x => x.ToDelimitedString())) : null,
                                ResourceQuantity.HasValue ? ResourceQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                ResourceQuantityUnits?.ToDelimitedString(),
                                StartDateTime?.ToHl7DateTimeString(typeof(AigSegment), nameof(StartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
