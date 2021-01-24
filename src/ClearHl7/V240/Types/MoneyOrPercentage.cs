using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 MOP - Money Or Percentage.
    /// </summary>
    public class MoneyOrPercentage : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MOP.1 - Money or Percentage Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0148</remarks>
        public string MoneyOrPercentageIndicator { get; set; }

        /// <summary>
        /// MOP.2 - Money or Percentage Quantity.
        /// </summary>
        public decimal? MoneyOrPercentageQuantity { get; set; }

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
                                MoneyOrPercentageIndicator,
                                MoneyOrPercentageQuantity.HasValue ? MoneyOrPercentageQuantity.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
