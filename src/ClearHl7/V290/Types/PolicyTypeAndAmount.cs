using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 PTA - Policy Type And Amount.
    /// </summary>
    public class PolicyTypeAndAmount : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PTA.1 - Policy Type.
        /// <para>Suggested: 0147 Policy Type -&gt; ClearHl7.Codes.V290.CodePolicyType</para>
        /// </summary>
        public CodedWithExceptions PolicyType { get; set; }

        /// <summary>
        /// PTA.2 - Amount Class.
        /// <para>Suggested: 0193 Amount Class -&gt; ClearHl7.Codes.V290.CodeAmountClass</para>
        /// </summary>
        public CodedWithExceptions AmountClass { get; set; }

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
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                PolicyType?.ToDelimitedString(),
                                AmountClass?.ToDelimitedString(),
                                MoneyOrPercentageQuantity.HasValue ? MoneyOrPercentageQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                MoneyOrPercentage?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
