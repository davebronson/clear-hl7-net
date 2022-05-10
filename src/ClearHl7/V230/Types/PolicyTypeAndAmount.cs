using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 PTA - Policy Type And Amount.
    /// </summary>
    public class PolicyTypeAndAmount : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTypeAndAmount"/> class.
        /// </summary>
        public PolicyTypeAndAmount()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTypeAndAmount"/> class.
        /// </summary>
        /// <param name="policyType">PTA.1 - Policy Type.</param>
        public PolicyTypeAndAmount(string policyType)
        {
            PolicyType = policyType;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PTA.1 - Policy Type.
        /// </summary>
        public string PolicyType { get; set; }

        /// <summary>
        /// PTA.2 - Amount Class.
        /// </summary>
        public string AmountClass { get; set; }

        /// <summary>
        /// PTA.3 - Money or Percentage Quantity.
        /// </summary>
        public decimal? MoneyOrPercentageQuantity { get; set; }

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

            PolicyType = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            AmountClass = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            MoneyOrPercentageQuantity = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                PolicyType,
                                AmountClass,
                                MoneyOrPercentageQuantity.HasValue ? MoneyOrPercentageQuantity.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
