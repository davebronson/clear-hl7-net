using System;

namespace ClearHl7.Fhir.V230.Types
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0472</remarks>
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

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}&{9}&{10}&{11}" : "{0}^{1}^{2}^{3}^{4}^{5}^{6}^{7}^{8}^{9}^{10}^{11}",
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
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
