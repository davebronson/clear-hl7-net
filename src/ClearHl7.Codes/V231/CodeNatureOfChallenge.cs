namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0257 - Nature Of Challenge.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0257</remarks>
    public enum CodeNatureOfChallenge
    {
        /// <summary>
        /// CFST - Fasting (no calorie intake) for the period specified in the time component of the term, e.g., 1H POST CFST.
        /// </summary>
        FastingForPeriodSpecified,

        /// <summary>
        /// EXCZ - Exercise undertaken as challenge (can be quantified).
        /// </summary>
        ExerciseCanBeQuantified,

        /// <summary>
        /// FFST - No fluid intake for the period specified in the time component of the term.
        /// </summary>
        NoFluidIntakeForPeriodSpecified
    }
}
