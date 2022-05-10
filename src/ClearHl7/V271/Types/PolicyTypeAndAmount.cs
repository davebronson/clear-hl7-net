using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V271.Types
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
        public PolicyTypeAndAmount(CodedWithExceptions policyType)
        {
            PolicyType = policyType;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PTA.1 - Policy Type.
        /// <para>Suggested: 0147 Policy Type -&gt; ClearHl7.Codes.V271.CodePolicyType</para>
        /// </summary>
        public CodedWithExceptions PolicyType { get; set; }

        /// <summary>
        /// PTA.2 - Amount Class.
        /// <para>Suggested: 0193 Amount Class -&gt; ClearHl7.Codes.V271.CodeAmountClass</para>
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

            PolicyType = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            AmountClass = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], true, seps) : null;
            MoneyOrPercentageQuantity = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            MoneyOrPercentage = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<MoneyOrPercentage>(segments[3], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
