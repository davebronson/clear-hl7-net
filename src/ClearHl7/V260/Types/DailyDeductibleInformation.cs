using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 DDI - Daily Deductible Information.
    /// </summary>
    public class DailyDeductibleInformation : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDeductibleInformation"/> class.
        /// </summary>
        public DailyDeductibleInformation()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDeductibleInformation"/> class.
        /// </summary>
        /// <param name="delayDays">DDI.1 - Delay Days.</param>
        public DailyDeductibleInformation(decimal delayDays)
        {
            DelayDays = delayDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDeductibleInformation"/> class.
        /// </summary>
        /// <param name="delayDays">DDI.1 - Delay Days.</param>
        /// <param name="monetaryAmount">DDI.2 - Monetary Amount.</param>
        public DailyDeductibleInformation(decimal delayDays, Money monetaryAmount)
        {
            DelayDays = delayDays;
            MonetaryAmount = monetaryAmount;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DDI.1 - Delay Days.
        /// </summary>
        public decimal? DelayDays { get; set; }

        /// <summary>
        /// DDI.2 - Monetary Amount.
        /// </summary>
        public Money MonetaryAmount { get; set; }

        /// <summary>
        /// DDI.3 - Number of Days.
        /// </summary>
        public decimal? NumberOfDays { get; set; }

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

            DelayDays = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDecimal() : null;
            MonetaryAmount = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[1], true, seps) : null;
            NumberOfDays = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                DelayDays.HasValue ? DelayDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                MonetaryAmount?.ToDelimitedString(),
                                NumberOfDays.HasValue ? NumberOfDays.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
