using System;

namespace ClearHl7.Fhir.V240.Types
{
    /// <summary>
    /// HL7 Version 2 CQ - Composite Quantity With Units.
    /// </summary>
    public class CompositeQuantityWithUnits : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CQ.1 - Quantity.
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// CQ.2 - Units.
        /// </summary>  
        public CodedElement Units { get; set; }

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
                                Quantity.HasValue ? Quantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                Units?.ToDelimitedString()
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
