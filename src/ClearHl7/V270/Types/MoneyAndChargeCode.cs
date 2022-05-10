using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 MOC - Money And Charge Code.
    /// </summary>
    public class MoneyAndChargeCode : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyAndChargeCode"/> class.
        /// </summary>
        public MoneyAndChargeCode()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyAndChargeCode"/> class.
        /// </summary>
        /// <param name="monetaryAmount">MOC.1 - Monetary Amount.</param>
        public MoneyAndChargeCode(Money monetaryAmount)
        {
            MonetaryAmount = monetaryAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyAndChargeCode"/> class.
        /// </summary>
        /// <param name="monetaryAmount">MOC.1 - Monetary Amount.</param>
        /// <param name="chargeCode">MOC.2 - Charge Code.</param>
        public MoneyAndChargeCode(Money monetaryAmount, CodedWithExceptions chargeCode)
        {
            MonetaryAmount = monetaryAmount;
            ChargeCode = chargeCode;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MOC.1 - Monetary Amount.
        /// </summary>
        public Money MonetaryAmount { get; set; }

        /// <summary>
        /// MOC.2 - Charge Code.
        /// </summary>
        public CodedWithExceptions ChargeCode { get; set; }

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

            MonetaryAmount = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[0], true, seps) : null;
            ChargeCode = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                MonetaryAmount?.ToDelimitedString(),
                                ChargeCode?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
