namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0389 - Analyte Repeat Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0389</remarks>
    public enum CodeAnalyteRepeatStatus
    {
        /// <summary>
        /// D - Repeated with dilution.
        /// </summary>
        RepeatedWithDilution,

        /// <summary>
        /// F - Reflex test.
        /// </summary>
        ReflexTest,

        /// <summary>
        /// O - Original, first run.
        /// </summary>
        OriginalFirstRun,

        /// <summary>
        /// R - Repeated without dilution.
        /// </summary>
        RepeatedWithoutDilution
    }
}
