namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0080 - Nature Of Abnormal Testing.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0080</remarks>
    public enum CodeNatureOfAbnormalTesting
    {
        /// <summary>
        /// A - An age-based population.
        /// </summary>
        AgeBasedPopulation,

        /// <summary>
        /// N - None - generic normal range.
        /// </summary>
        None,

        /// <summary>
        /// R - A race-based population.
        /// </summary>
        RaceBasedPopulation,

        /// <summary>
        /// S - A sex-based population.
        /// </summary>
        SexBasedPopulation
    }
}
