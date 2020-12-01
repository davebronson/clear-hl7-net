using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V281.Types
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0153</remarks>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            char separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                ValueCode?.ToDelimitedString(),
                                ValueAmount?.ToDelimitedString(),
                                NonMonetaryValueAmountQuantity.HasValue ? NonMonetaryValueAmountQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                NonMonetaryValueAmountUnits?.ToDelimitedString()
                                ).TrimEnd(separator);
        }
    }
}
