using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V250.Types
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
        /// <para>Suggested: 0472 TQ Conjunction ID -&gt; ClearHl7.Codes.V250.CodeTqConjunctionId</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            Quantity = segments.Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(0), true) : null;
            Interval = segments.Length > 1 ? TypeHelper.Deserialize<RepeatInterval>(segments.ElementAtOrDefault(1), true) : null;
            Duration = segments.ElementAtOrDefault(2);
            StartDateTime = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EndDateTime = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            Priority = segments.ElementAtOrDefault(5);
            Condition = segments.ElementAtOrDefault(6);
            Text = segments.Length > 7 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(7), true) : null;
            Conjunction = segments.ElementAtOrDefault(8);
            OrderSequencing = segments.Length > 9 ? TypeHelper.Deserialize<OrderSequenceDefinition>(segments.ElementAtOrDefault(9), true) : null;
            OccurrenceDuration = segments.Length > 10 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(10), true) : null;
            TotalOccurrences = segments.ElementAtOrDefault(11)?.ToNullableDecimal();
        }

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
