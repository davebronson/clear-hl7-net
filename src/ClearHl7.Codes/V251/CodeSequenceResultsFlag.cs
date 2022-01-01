namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0503 - Sequence/Results Flag.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0503</remarks>
    public enum CodeSequenceResultsFlag
    {
        /// <summary>
        /// C - Cyclical.
        /// </summary>
        Cyclical,

        /// <summary>
        /// R - Reserved for future use.
        /// </summary>
        ReservedForFutureUse,

        /// <summary>
        /// S - Sequential.
        /// </summary>
        Sequential
    }
}
