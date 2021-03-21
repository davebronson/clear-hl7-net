using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 MO - Money.
    /// </summary>
    public class Money : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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
                                StringHelper.StringFormatSequence(0, 2, separator),
                                Quantity.HasValue ? Quantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                Denomination
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
