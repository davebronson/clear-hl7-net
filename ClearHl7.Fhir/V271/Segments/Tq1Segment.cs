using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0485</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0472</remarks>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}