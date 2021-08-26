using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V270.CodeSegmentActionCode</para>
        /// </summary>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// AIS.3 - Universal Service Identifier.
        /// </summary>
        public CodedWithExceptions UniversalServiceIdentifier { get; set; }

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
        public CodedWithNoExceptions StartDateTimeOffsetUnits { get; set; }

        /// <summary>
        /// AIS.7 - Duration.
        /// </summary>
        public decimal? Duration { get; set; }

        /// <summary>
        /// AIS.8 - Duration Units.
        /// </summary>
        public CodedWithNoExceptions DurationUnits { get; set; }

        /// <summary>
        /// AIS.9 - Allow Substitution Code.
        /// <para>Suggested: 0279 Allow Substitution Codes -&gt; ClearHl7.Codes.V270.CodeAllowSubstitutionCodes</para>
        /// </summary>
        public CodedWithExceptions AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIS.10 - Filler Status Code.
        /// <para>Suggested: 0278 Filler Status Codes -&gt; ClearHl7.Codes.V270.CodeFillerStatusCodes</para>
        /// </summary>
        public CodedWithExceptions FillerStatusCode { get; set; }

        /// <summary>
        /// AIS.11 - Placer Supplemental Service Information.
        /// <para>Suggested: 0411 Supplemental Service Information Values -&gt; ClearHl7.Codes.V270.CodeSupplementalServiceInformationValues</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PlacerSupplementalServiceInformation { get; set; }

        /// <summary>
        /// AIS.12 - Filler Supplemental Service Information.
        /// <para>Suggested: 0411 Supplemental Service Information Values -&gt; ClearHl7.Codes.V270.CodeSupplementalServiceInformationValues</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> FillerSupplementalServiceInformation { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdAis = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            SegmentActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            UniversalServiceIdentifier = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false) : null;
            StartDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            StartDateTimeOffset = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            StartDateTimeOffsetUnits = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[6], false) : null;
            Duration = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            DurationUnits = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[8], false) : null;
            AllowSubstitutionCode = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[9], false) : null;
            FillerStatusCode = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[10], false) : null;
            PlacerSupplementalServiceInformation = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            FillerSupplementalServiceInformation = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
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
                                SetIdAis.HasValue ? SetIdAis.Value.ToString(culture) : null,
                                SegmentActionCode,
                                UniversalServiceIdentifier?.ToDelimitedString(),
                                StartDateTime.HasValue ? StartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StartDateTimeOffset.HasValue ? StartDateTimeOffset.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartDateTimeOffsetUnits?.ToDelimitedString(),
                                Duration.HasValue ? Duration.Value.ToString(Consts.NumericFormat, culture) : null,
                                DurationUnits?.ToDelimitedString(),
                                AllowSubstitutionCode?.ToDelimitedString(),
                                FillerStatusCode?.ToDelimitedString(),
                                PlacerSupplementalServiceInformation != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerSupplementalServiceInformation.Select(x => x.ToDelimitedString())) : null,
                                FillerSupplementalServiceInformation != null ? string.Join(Configuration.FieldRepeatSeparator, FillerSupplementalServiceInformation.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}