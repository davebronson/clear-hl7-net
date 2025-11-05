using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 TQ - Timing Quantity.
    /// </summary>
    public class TimingQuantity : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimingQuantity"/> class.
        /// </summary>
        public TimingQuantity()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimingQuantity"/> class.
        /// </summary>
        /// <param name="quantity">TQ.1 - Quantity.</param>
        public TimingQuantity(CompositeQuantityWithUnits quantity)
        {
            Quantity = quantity;
        }

        /// <inheritdoc/>
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
        /// <para>Suggested: 0472 TQ Conjunction ID -&gt; ClearHl7.Codes.V251.CodeTqConjunctionId</para>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            Quantity = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[0], true, seps) : null;
            Interval = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<RepeatInterval>(segments[1], true, seps) : null;
            Duration = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            StartDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            EndDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            Priority = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Condition = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            Text = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[7], true, seps) : null;
            Conjunction = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            OrderSequencing = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<OrderSequenceDefinition>(segments[9], true, seps) : null;
            OccurrenceDuration = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[10], true, seps) : null;
            TotalOccurrences = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 12, separator),
                                Quantity?.ToDelimitedString(),
                                Interval?.ToDelimitedString(),
                                Duration,
                                StartDateTime?.ToHl7DateTimeString(typeof(TimingQuantity), nameof(StartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EndDateTime?.ToHl7DateTimeString(typeof(TimingQuantity), nameof(EndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
