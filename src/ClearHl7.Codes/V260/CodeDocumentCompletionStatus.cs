namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0271 - Document Completion Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0271</remarks>
    public enum CodeDocumentCompletionStatus
    {
        /// <summary>
        /// AU - Authenticated.
        /// </summary>
        Authenticated,

        /// <summary>
        /// DI - Dictated.
        /// </summary>
        Dictated,

        /// <summary>
        /// DO - Documented.
        /// </summary>
        Documented,

        /// <summary>
        /// IN - Incomplete.
        /// </summary>
        Incomplete,

        /// <summary>
        /// IP - In Progress.
        /// </summary>
        InProgress,

        /// <summary>
        /// LA - Legally authenticated.
        /// </summary>
        LegallyAuthenticated,

        /// <summary>
        /// PA - Pre-authenticated.
        /// </summary>
        PreAuthenticated
    }
}
