using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 RMC - Room Coverage.
    /// </summary>
    public class RoomCoverage : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RMC.1 - Room Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0145</remarks>
        public string RoomType { get; set; }

        /// <summary>
        /// RMC.2 - Amount Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0146</remarks>
        public string AmountType { get; set; }

        /// <summary>
        /// RMC.3 - Coverage Amount.
        /// </summary>
        public decimal? CoverageAmount { get; set; }

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
                                StringHelper.StringFormatSequence(0, 3, separator),
                                RoomType,
                                AmountType,
                                CoverageAmount.HasValue ? CoverageAmount.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
