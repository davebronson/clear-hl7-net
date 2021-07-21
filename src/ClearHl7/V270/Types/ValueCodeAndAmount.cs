using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 UVC - Value Code And Amount.
    /// </summary>
    public class ValueCodeAndAmount : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// UVC.1 - Value Code.
        /// <para>Suggested: 0153 Value Code -&gt; ClearHl7.Codes.V270.CodeValueCode</para>
        /// </summary>
        public CodedWithExceptions ValueCode { get; set; }

        /// <summary>
        /// UVC.2 - Value Amount.
        /// </summary>
        public Money ValueAmount { get; set; }

        /// <summary>
        /// UVC.3 - Non-Monetary Value Amount / Quantity.
        /// </summary>
        public decimal? NonMonetaryValueAmountQuantity { get; set; }

        /// <summary>
        /// UVC.4 - Non-Monetary Value Amount / Units.
        /// </summary>
        public CodedWithExceptions NonMonetaryValueAmountUnits { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            if (segments.Length > 0)
            {
                ValueCode = new CodedWithExceptions { IsSubcomponent = true };
                ValueCode.FromDelimitedString(segments.ElementAtOrDefault(0));
            }
            else
            {
                ValueCode = null;
            }

            if (segments.Length > 1)
            {
                ValueAmount = new Money { IsSubcomponent = true };
                ValueAmount.FromDelimitedString(segments.ElementAtOrDefault(1));
            }
            else
            {
                ValueAmount = null;
            }

            NonMonetaryValueAmountQuantity = segments.ElementAtOrDefault(2)?.ToNullableDecimal();

            if (segments.Length > 3)
            {
                NonMonetaryValueAmountUnits = new CodedWithExceptions { IsSubcomponent = true };
                NonMonetaryValueAmountUnits.FromDelimitedString(segments.ElementAtOrDefault(3));
            }
            else
            {
                NonMonetaryValueAmountUnits = null;
            }
        }

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
                                ValueCode?.ToDelimitedString(),
                                ValueAmount?.ToDelimitedString(),
                                NonMonetaryValueAmountQuantity.HasValue ? NonMonetaryValueAmountQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                NonMonetaryValueAmountUnits?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
