using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CSS - Clinical Study Data Schedule Segment.
    /// </summary>
    public class CssSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CSS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CSS.1 - Study Scheduled Time Point.
        /// </summary>
        public CodedWithExceptions StudyScheduledTimePoint { get; set; }

        /// <summary>
        /// CSS.2 - Study Scheduled Patient Time Point.
        /// </summary>
        public DateTime? StudyScheduledPatientTimePoint { get; set; }

        /// <summary>
        /// CSS.3 - Study Quality Control Codes.
        /// </summary>
        public IEnumerable<CodedWithExceptions> StudyQualityControlCodes { get; set; }

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

            StudyScheduledTimePoint = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[1], false) : null;
            StudyScheduledPatientTimePoint = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            StudyQualityControlCodes = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                StudyScheduledTimePoint?.ToDelimitedString(),
                                StudyScheduledPatientTimePoint.HasValue ? StudyScheduledPatientTimePoint.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StudyQualityControlCodes != null ? string.Join(Configuration.FieldRepeatSeparator, StudyQualityControlCodes.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}