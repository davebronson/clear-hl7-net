using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 MA - Multiplexed Array.
    /// </summary>
    public class MultiplexedArray
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MA.1 - Sample Y From Channel 1.
        /// </summary>
        public decimal? SampleYFromChannel1 { get; set; }

        /// <summary>
        /// MA.2 - Sample Y From Channel 2.
        /// </summary>
        public decimal? SampleYFromChannel2 { get; set; }

        /// <summary>
        /// MA.3 - Sample Y From Channel 3.
        /// </summary>
        public decimal? SampleYFromChannel3 { get; set; }

        /// <summary>
        /// MA.4 - Sample Y From Channel 4.
        /// </summary>
        public decimal? SampleYFromChannel4 { get; set; }

        /// <summary>
        /// Returns a pipe-delimited representation of this instance. 
        /// </summary>
        /// <returns>A string.</returns>
        public string ToPipeString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}" : "{0}^{1}^{2}^{3}",
                                SampleYFromChannel1.HasValue ? SampleYFromChannel1.Value.ToString(Consts.NumericFormat, culture) : null,
                                SampleYFromChannel2.HasValue ? SampleYFromChannel2.Value.ToString(Consts.NumericFormat, culture) : null,
                                SampleYFromChannel3.HasValue ? SampleYFromChannel3.Value.ToString(Consts.NumericFormat, culture) : null,
                                SampleYFromChannel4.HasValue ? SampleYFromChannel4.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
