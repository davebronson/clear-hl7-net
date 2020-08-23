using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 WVS - Waveform Source.
    /// </summary>
    public class WaveformSource
    {
        /// <summary>
        /// WVS.1 - Source One Name.
        /// </summary>
        public string SourceOneName { get; set; }

        /// <summary>
        /// WVS.2 - Source Two Name.
        /// </summary>
        public string SourceTwoName { get; set; }
    }
}
