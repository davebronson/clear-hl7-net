using System;

namespace ClearHl7.Fhir.V240.Types
{
    /// <summary>
    /// HL7 Version 2 DDI - Daily Deductible Information.
    /// </summary>
    public class DailyDeductibleInformation : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DDI.1 - Delay Days.
        /// </summary>
        public decimal? DelayDays { get; set; }

        /// <summary>
        /// DDI.22 - Monetary Amount.
        /// </summary>
        public decimal? MonetaryAmount { get; set; }

        /// <summary>
        /// DDI.3 - Number of Days.
        /// </summary>
        public decimal? NumberOfDays { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}" : "{0}^{1}^{2}",
                                DelayDays.HasValue ? DelayDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                MonetaryAmount.HasValue ? MonetaryAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                NumberOfDays.HasValue ? NumberOfDays.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
