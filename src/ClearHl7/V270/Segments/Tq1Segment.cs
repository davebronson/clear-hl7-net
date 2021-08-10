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
    /// HL7 Version 2 Segment TQ1 - Timing Quantity.
    /// </summary>
    public class Tq1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "TQ1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// TQ1.1 - Set ID - TQ1.
        /// </summary>
        public uint? SetIdTq1 { get; set; }

        /// <summary>
        /// TQ1.2 - Quantity.
        /// </summary>
        public CompositeQuantityWithUnits Quantity { get; set; }

        /// <summary>
        /// TQ1.3 - Repeat Pattern.
        /// </summary>
        public IEnumerable<RepeatPattern> RepeatPattern { get; set; }

        /// <summary>
        /// TQ1.4 - Explicit Time.
        /// </summary>
        public IEnumerable<DateTime> ExplicitTime { get; set; }

        /// <summary>
        /// TQ1.5 - Relative Time and Units.
        /// </summary>
        public IEnumerable<CompositeQuantityWithUnits> RelativeTimeAndUnits { get; set; }

        /// <summary>
        /// TQ1.6 - Service Duration.
        /// </summary>
        public CompositeQuantityWithUnits ServiceDuration { get; set; }

        /// <summary>
        /// TQ1.7 - Start date/time.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// TQ1.8 - End date/time.
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// TQ1.9 - Priority.
        /// <para>Suggested: 0485 Extended Priority Codes -&gt; ClearHl7.Codes.V270.CodeExtendedPriorityCodes</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Priority { get; set; }

        /// <summary>
        /// TQ1.10 - Condition text.
        /// </summary>
        public Text ConditionText { get; set; }

        /// <summary>
        /// TQ1.11 - Text instruction.
        /// </summary>
        public Text TextInstruction { get; set; }

        /// <summary>
        /// TQ1.12 - Conjunction.
        /// <para>Suggested: 0472 TQ Conjunction ID -&gt; ClearHl7.Codes.V270.CodeTqConjunctionId</para>
        /// </summary>
        public string Conjunction { get; set; }

        /// <summary>
        /// TQ1.13 - Occurrence duration.
        /// </summary>
        public CompositeQuantityWithUnits OccurrenceDuration { get; set; }

        /// <summary>
        /// TQ1.14 - Total occurrences.
        /// </summary>
        public decimal? TotalOccurrences { get; set; }

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
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdTq1 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            Quantity = segments.Length > 2 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(2), false) : null;
            RepeatPattern = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<RepeatPattern>(x, false)) : null;
            ExplicitTime = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => x.ToDateTime(Consts.TimeFormatPrecisionSecond)) : null;
            RelativeTimeAndUnits = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<CompositeQuantityWithUnits>(x, false)) : null;
            ServiceDuration = segments.Length > 6 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(6), false) : null;
            StartDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EndDateTime = segments.ElementAtOrDefault(8)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            Priority = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ConditionText = segments.Length > 10 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(10), false) : null;
            TextInstruction = segments.Length > 11 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(11), false) : null;
            Conjunction = segments.ElementAtOrDefault(12);
            OccurrenceDuration = segments.Length > 13 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(13), false) : null;
            TotalOccurrences = segments.ElementAtOrDefault(14)?.ToNullableDecimal();
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
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                SetIdTq1.HasValue ? SetIdTq1.Value.ToString(culture) : null,
                                Quantity?.ToDelimitedString(),
                                RepeatPattern != null ? string.Join(Configuration.FieldRepeatSeparator, RepeatPattern.Select(x => x.ToDelimitedString())) : null,
                                ExplicitTime != null ? string.Join(Configuration.FieldRepeatSeparator, ExplicitTime.Select(x => x.ToString(Consts.TimeFormatPrecisionSecond, culture))) : null,
                                RelativeTimeAndUnits != null ? string.Join(Configuration.FieldRepeatSeparator, RelativeTimeAndUnits.Select(x => x.ToDelimitedString())) : null,
                                ServiceDuration?.ToDelimitedString(),
                                StartDateTime.HasValue ? StartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EndDateTime.HasValue ? EndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                Priority != null ? string.Join(Configuration.FieldRepeatSeparator, Priority.Select(x => x.ToDelimitedString())) : null,
                                ConditionText?.ToDelimitedString(),
                                TextInstruction?.ToDelimitedString(),
                                Conjunction,
                                OccurrenceDuration?.ToDelimitedString(),
                                TotalOccurrences.HasValue ? TotalOccurrences.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}