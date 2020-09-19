using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 NR - Numeric Range.
    /// </summary>
    public class NumericRange : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// NR.1 - Low Value.
        /// </summary>
        public decimal? LowValue { get; set; }

        /// <summary>
        /// NR.2 - High Value.
        /// </summary>
        public decimal? HighValue { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}" : "{0}^{1}",
                                LowValue.HasValue ? LowValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                HighValue.HasValue ? HighValue.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
