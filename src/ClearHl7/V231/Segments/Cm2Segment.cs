using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CM2 - Clinical Study Schedule Master.
    /// </summary>
    public class Cm2Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cm2Segment"/> class.
        /// </summary>
        public Cm2Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cm2Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Cm2Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "CM2";

        /// <inheritdoc/>
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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdCm2 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ScheduledTimePoint = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            DescriptionOfTimePoint = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            EventsScheduledThisTimePoint = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
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
