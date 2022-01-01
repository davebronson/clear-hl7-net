namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0250 - Relatedness Assessment.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0250</remarks>
    public enum CodeRelatednessAssessment
    {
        /// <summary>
        /// H - Highly probable.
        /// </summary>
        HighlyProbable,

        /// <summary>
        /// I - Improbable.
        /// </summary>
        Improbable,

        /// <summary>
        /// M - Moderately probable.
        /// </summary>
        ModeratelyProbable,

        /// <summary>
        /// N - Not related.
        /// </summary>
        NotRelated,

        /// <summary>
        /// S - Somewhat probable.
        /// </summary>
        SomewhatProbable
    }
}
