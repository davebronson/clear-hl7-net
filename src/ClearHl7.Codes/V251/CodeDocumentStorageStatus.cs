namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0275 - Document Storage Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0275</remarks>
    public enum CodeDocumentStorageStatus
    {
        /// <summary>
        /// AA - Active and archived.
        /// </summary>
        ActiveAndArchived,

        /// <summary>
        /// AC - Active.
        /// </summary>
        Active,

        /// <summary>
        /// AR - Archived (not active).
        /// </summary>
        Archived,

        /// <summary>
        /// PU - Purged.
        /// </summary>
        Purged
    }
}
