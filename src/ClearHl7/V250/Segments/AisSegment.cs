using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AIS - Appointment Information.
    /// </summary>
    public class AisSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AisSegment"/> class.
        /// </summary>
        public AisSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AisSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public AisSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "AIS";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// AIS.1 - Set ID - AIS.
        /// </summary>
        public uint? SetIdAis { get; set; }

        /// <summary>
        /// AIS.2 - Segment Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V250.CodeSegmentActionCode</para>
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
        /// <para>Suggested: 0279 Allow Substitution Codes -&gt; ClearHl7.Codes.V250.CodeAllowSubstitutionCodes</para>
        /// </summary>
        public string AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIS.10 - Filler Status Code.
        /// <para>Suggested: 0278 Filler Status Codes -&gt; ClearHl7.Codes.V250.CodeFillerStatusCodes</para>
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

            SetIdAis = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            SegmentActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            UniversalServiceIdentifier = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            StartDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            StartDateTimeOffset = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            StartDateTimeOffsetUnits = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[6], false, seps) : null;
            Duration = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            DurationUnits = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[8], false, seps) : null;
            AllowSubstitutionCode = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            FillerStatusCode = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[10], false, seps) : null;
            PlacerSupplementalServiceInformation = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            FillerSupplementalServiceInformation = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                SetIdAis.HasValue ? SetIdAis.Value.ToString(culture) : null,
                                SegmentActionCode,
                                UniversalServiceIdentifier?.ToDelimitedString(),
                                StartDateTime?.ToHl7DateTimeString(typeof(AisSegment), nameof(StartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
