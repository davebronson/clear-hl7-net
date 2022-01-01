namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0287 - Problem/Goal Action Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0287</remarks>
    public enum CodeProblemGoalActionCode
    {
        /// <summary>
        /// AD - ADD.
        /// </summary>
        Add,

        /// <summary>
        /// CO - CORRECT.
        /// </summary>
        Correct,

        /// <summary>
        /// DE - DELETE.
        /// </summary>
        Delete,

        /// <summary>
        /// LI - LINK.
        /// </summary>
        Link,

        /// <summary>
        /// UC - UNCHANGED.
        /// </summary>
        Unchanged,

        /// <summary>
        /// UN - UNLINK.
        /// </summary>
        Unlink,

        /// <summary>
        /// UP - UPDATE.
        /// </summary>
        Update
    }
}
