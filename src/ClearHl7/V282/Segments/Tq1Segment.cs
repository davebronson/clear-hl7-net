using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment TQ1 - Timing Quantity.
    /// </summary>
    public class Tq1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tq1Segment"/> class.
        /// </summary>
        public Tq1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tq1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Tq1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "TQ1";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0485 Extended Priority Codes -&gt; ClearHl7.Codes.V282.CodeExtendedPriorityCodes</para>
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
        /// <para>Suggested: 0472 TQ Conjunction ID -&gt; ClearHl7.Codes.V282.CodeTqConjunctionId</para>
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

            SetIdTq1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            Quantity = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[2], false, seps) : null;
            RepeatPattern = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<RepeatPattern>(x, false, seps)) : null;
            ExplicitTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            RelativeTimeAndUnits = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CompositeQuantityWithUnits>(x, false, seps)) : null;
            ServiceDuration = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[6], false, seps) : null;
            StartDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            EndDateTime = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            Priority = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ConditionText = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[10], false, seps) : null;
            TextInstruction = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[11], false, seps) : null;
            Conjunction = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            OccurrenceDuration = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[13], false, seps) : null;
            TotalOccurrences = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
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
                                StartDateTime?.ToHl7DateTimeString(typeof(Tq1Segment), nameof(StartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EndDateTime?.ToHl7DateTimeString(typeof(Tq1Segment), nameof(EndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
