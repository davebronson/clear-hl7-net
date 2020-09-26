using System;

namespace ClearHl7.Fhir.V250.Types
{
    /// <summary>
    /// HL7 Version 2 DLT - Delta.
    /// </summary>
    public class Delta : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DLT.1 - Normal Range.
        /// </summary>
        public NumericRange NormalRange { get; set; }

        /// <summary>
        /// DLT.2 - Numeric Threshold.
        /// </summary>
        public decimal? NumericThreshold { get; set; }

        /// <summary>
        /// DLT.3 - Change Computation.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0523</remarks>
        public string ChangeComputation { get; set; }

        /// <summary>
        /// DLT.4 - Days Retained.
        /// </summary>
        public decimal? DaysRetained { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}" : "{0}^{1}^{2}^{3}",
                                NormalRange?.ToDelimitedString(),
                                NumericThreshold.HasValue ? NumericThreshold.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChangeComputation,
                                DaysRetained.HasValue ? DaysRetained.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
