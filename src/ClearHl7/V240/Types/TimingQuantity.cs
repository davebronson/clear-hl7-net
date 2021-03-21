using System;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 TQ - Timing Quantity.
    /// </summary>
    public class TimingQuantity : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// TQ.1 - Quantity.
        /// </summary>
        public CompositeQuantityWithUnits Quantity { get; set; }

        /// <summary>
        /// TQ.2 - Interval.
        /// </summary>
        public RepeatInterval Interval { get; set; }

        /// <summary>
        /// TQ.3 - Duration.
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// TQ.4 - Start Date/Time.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// TQ.5 - End Date/Time.
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// TQ.6 - Priority.
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// TQ.7 - Condition.
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// TQ.8 - Text.
        /// </summary>
        public Text Text { get; set; }

        /// <summary>
        /// TQ.9 - Conjunction.
        /// <para>Suggested: 0472 TQ Conjunction ID -&gt; ClearHl7.Codes.V240.CodeTqConjunctionId</para>
        /// </summary>
        public string Conjunction { get; set; }

        /// <summary>
        /// TQ.10 - Order Sequencing.
        /// </summary>
        public OrderSequenceDefinition OrderSequencing { get; set; }

        /// <summary>
        /// TQ.11 - Occurrence Duration.
        /// </summary>
        public CodedElement OccurrenceDuration { get; set; }

        /// <summary>
        /// TQ.12 - Total Occurrences.
        /// </summary>
        public decimal? TotalOccurrences { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 12, separator),
                                Quantity?.ToDelimitedString(),
                                Interval?.ToDelimitedString(),
                                Duration,
                                StartDateTime.HasValue ? StartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EndDateTime.HasValue ? EndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                Priority,
                                Condition,
                                Text?.ToDelimitedString(),
                                Conjunction,
                                OrderSequencing?.ToDelimitedString(),
                                OccurrenceDuration?.ToDelimitedString(),
                                TotalOccurrences.HasValue ? TotalOccurrences.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
