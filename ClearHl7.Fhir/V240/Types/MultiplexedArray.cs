using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V240.Types
{
    /// <summary>
    /// HL7 Version 2 MA - Multiplexed Array.
    /// </summary>
    public class MultiplexedArray : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MA.1 - Sample 1 From Channel 1.
        /// </summary>
        public decimal? Sample1FromChannel1 { get; set; }

        /// <summary>
        /// MA.2 - Sample 1 From Channel 2.
        /// </summary>
        public decimal? Sample1FromChannel2 { get; set; }

        /// <summary>
        /// MA.3 - Sample 1 From Channel N.
        /// </summary>
        public decimal? Sample1FromChannelN { get; set; }

        /// <summary>
        /// MA.4 - Sample 2 From Channel 1.
        /// </summary>
        public decimal? Sample2FromChannel1 { get; set; }

        /// <summary>
        /// MA.5 - Sample 2 From Channel N.
        /// </summary>
        public decimal? Sample2FromChannelN { get; set; }

        /// <summary>
        /// MA.6 - Sample N From Channel N.
        /// </summary>
        public decimal? SampleNFromChannelN { get; set; }

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
                                StringHelper.StringFormatSequence(0, 6, separator),
                                Sample1FromChannel1.HasValue ? Sample1FromChannel1.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sample1FromChannel2.HasValue ? Sample1FromChannel2.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sample1FromChannelN.HasValue ? Sample1FromChannelN.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sample2FromChannel1.HasValue ? Sample2FromChannel1.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sample2FromChannelN.HasValue ? Sample2FromChannelN.Value.ToString(Consts.NumericFormat, culture) : null,
                                SampleNFromChannelN.HasValue ? SampleNFromChannelN.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator);
        }
    }
}
