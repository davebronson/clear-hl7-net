using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
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
        /// <para>Suggested: 0153 Value Code</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(separator, StringSplitOptions.None);

            ValueCode = segments.Length > 0 && segments[0].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[0], true) : null;
            ValueAmount = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<Money>(segments[1], true) : null;
            NonMonetaryValueAmountQuantity = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            NonMonetaryValueAmountUnits = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], true) : null;
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
