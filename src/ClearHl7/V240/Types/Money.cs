using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 MO - Money.
    /// </summary>
    public class Money : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class.
        /// </summary>
        public Money()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class.
        /// </summary>
        /// <param name="quantity">MO.1 - Quantity.</param>
        public Money(decimal quantity)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class.
        /// </summary>
        /// <param name="quantity">MO.1 - Quantity.</param>
        /// <param name="denomination">MO.2 - Denomination.</param>
        public Money(decimal quantity, string denomination)
        {
            Quantity = quantity;
            Denomination = denomination;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MO.1 - Quantity.
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// MO.2 - Denomination.
        /// <para>Suggested: 0913 Currency Code -&gt; https://www.iso.org/iso-4217-currency-codes.html</para>
        /// </summary>
        public string Denomination { get; set; }

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

            Quantity = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDecimal() : null;
            Denomination = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                Quantity.HasValue ? Quantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                Denomination
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
