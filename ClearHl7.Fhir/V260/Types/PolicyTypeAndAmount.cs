using System;

namespace ClearHl7.Fhir.V260.Types
{
    /// <summary>
    /// HL7 Version 2 PTA - Policy Type And Amount.
    /// </summary>
    public class PolicyTypeAndAmount
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PTA.1 - Policy Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0147</remarks>
        public string PolicyType { get; set; }

        /// <summary>
        /// PTA.2 - Amount Class.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0193</remarks>
        public string AmountClass { get; set; }

        /// <summary>
        /// PTA.3 - Money or Percentage Quantity.
        /// </summary>
        public decimal? MoneyOrPercentageQuantity { get; set; }

        /// <summary>
        /// PTA.4 - Money or Percentage.
        /// </summary>
        public MoneyOrPercentage MoneyOrPercentage { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}" : "{0}^{1}^{2}^{3}",
                                PolicyType,
                                AmountClass,
                                MoneyOrPercentageQuantity.HasValue ? MoneyOrPercentageQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                MoneyOrPercentage?.ToDelimitedString()
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
