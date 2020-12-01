using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 SN - Structured Numeric.
    /// </summary>
    public class StructuredNumeric : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SN.1 - Comparator.
        /// </summary>
        public string Comparator { get; set; }

        /// <summary>
        /// SN.2 - Num1.
        /// </summary>
        public decimal? Num1 { get; set; }

        /// <summary>
        /// SN.3 - Separator/Suffix.
        /// </summary>
        public string SeparatorSuffix { get; set; }

        /// <summary>
        /// SN.4 - Num2.
        /// </summary>
        public decimal? Num2 { get; set; }

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
                                Comparator,
                                Num1.HasValue ? Num1.Value.ToString(Consts.NumericFormat, culture) : null,
                                SeparatorSuffix,
                                Num2.HasValue ? Num2.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator);
        }
    }
}
