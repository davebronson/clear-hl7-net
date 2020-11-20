using System;

namespace ClearHl7.Fhir.V240.Types
{
    /// <summary>
    /// HL7 Version 2 MOC - Charge To Practise.
    /// </summary>
    public class ChargeToPractise : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MOC.1 - Dollar Amount.
        /// </summary>
        public Money DollarAmount { get; set; }

        /// <summary>
        /// MOC.2 - Charge Code.
        /// </summary>
        public CodedElement ChargeCode { get; set; }

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
                                DollarAmount?.ToDelimitedString(),
                                ChargeCode?.ToDelimitedString()
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
