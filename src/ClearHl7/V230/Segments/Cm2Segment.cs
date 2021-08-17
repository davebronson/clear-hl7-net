using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CM2 - Clinical Study Schedule Master.
    /// </summary>
    public class Cm2Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CM2";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CM2.1 - Set ID- CM2.
        /// </summary>
        public uint? SetIdCm2 { get; set; }

        /// <summary>
        /// CM2.2 - Scheduled Time Point.
        /// </summary>
        public CodedElement ScheduledTimePoint { get; set; }

        /// <summary>
        /// CM2.3 - Description of Time Point.
        /// </summary>
        public string DescriptionOfTimePoint { get; set; }

        /// <summary>
        /// CM2.4 - Events Scheduled This Time Point.
        /// </summary>
        public IEnumerable<CodedElement> EventsScheduledThisTimePoint { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdCm2 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ScheduledTimePoint = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[2], false) : null;
            DescriptionOfTimePoint = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            EventsScheduledThisTimePoint = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                SetIdCm2.HasValue ? SetIdCm2.Value.ToString(culture) : null,
                                ScheduledTimePoint?.ToDelimitedString(),
                                DescriptionOfTimePoint,
                                EventsScheduledThisTimePoint != null ? string.Join(Configuration.FieldRepeatSeparator, EventsScheduledThisTimePoint.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}