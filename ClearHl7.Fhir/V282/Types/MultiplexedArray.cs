using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 MA - Multiplexed Array.
    /// </summary>
    public class MultiplexedArray
    {
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
    }
}
