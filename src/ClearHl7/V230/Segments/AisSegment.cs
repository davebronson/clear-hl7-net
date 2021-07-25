using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V230.CodeSegmentActionCode</para>
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
        /// <para>Suggested: 0279 Allow Substitution Codes -&gt; ClearHl7.Codes.V230.CodeAllowSubstitutionCodes</para>
        /// </summary>
        public string AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIS.10 - Filler Status Code.
        /// <para>Suggested: 0278 Filler Status Codes -&gt; ClearHl7.Codes.V230.CodeFillerStatusCodes</para>
        /// </summary>
        public CodedElement FillerStatusCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdAis = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            SegmentActionCode = segments.ElementAtOrDefault(2);
            UniversalServiceIdentifier = segments.Length > 3 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(3), false) : null;
            StartDateTime = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            StartDateTimeOffset = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            StartDateTimeOffsetUnits = segments.Length > 6 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(6), false) : null;
            Duration = segments.ElementAtOrDefault(7)?.ToNullableDecimal();
            DurationUnits = segments.Length > 8 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(8), false) : null;
            AllowSubstitutionCode = segments.ElementAtOrDefault(9);
            FillerStatusCode = segments.Length > 10 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(10), false) : null;
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
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
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
                                FillerStatusCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}