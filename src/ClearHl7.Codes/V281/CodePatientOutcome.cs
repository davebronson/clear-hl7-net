namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0241 - Patient Outcome.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0241</remarks>
    public enum CodePatientOutcome
    {
        /// <summary>
        /// D - Died.
        /// </summary>
        Died,

        /// <summary>
        /// F - Fully recovered.
        /// </summary>
        FullyRecovered,

        /// <summary>
        /// N - Not recovering/unchanged.
        /// </summary>
        NotRecoveringUnchanged,

        /// <summary>
        /// R - Recovering.
        /// </summary>
        Recovering,

        /// <summary>
        /// S - Sequelae.
        /// </summary>
        Sequelae,

        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// W - Worsening.
        /// </summary>
        Worsening
    }
}
