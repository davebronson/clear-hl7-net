using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 NA - Numeric Array.
    /// </summary>
    public class NumericArray : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// NA.1 - Value1.
        /// </summary>
        public decimal? Value1 { get; set; }

        /// <summary>
        /// NA.2 - Value2.
        /// </summary>
        public decimal? Value2 { get; set; }

        /// <summary>
        /// NA.3 - Value3.
        /// </summary>
        public decimal? Value3 { get; set; }

        /// <summary>
        /// NA.4 - Value4.
        /// </summary>
        public decimal? Value4 { get; set; }

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
                                Value1.HasValue ? Value1.Value.ToString(Consts.NumericFormat, culture) : null,
                                Value2.HasValue ? Value2.Value.ToString(Consts.NumericFormat, culture) : null,
                                Value3.HasValue ? Value3.Value.ToString(Consts.NumericFormat, culture) : null,
                                Value4.HasValue ? Value4.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
