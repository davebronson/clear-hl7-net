namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0207 - Processing Mode.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0207</remarks>
    public enum CodeProcessingMode
    {
        /// <summary>
        /// A - Archive.
        /// </summary>
        Archive,

        /// <summary>
        /// I - Initial load.
        /// </summary>
        InitialLoad,

        /// <summary>
        /// Not present - Not present (the default, meaning current  processing).
        /// </summary>
        NotPresent,

        /// <summary>
        /// R - Restore from archive.
        /// </summary>
        RestoreFromArchive,

        /// <summary>
        /// T - Current processing, transmitted at intervals (scheduled or on demand).
        /// </summary>
        CurrentProcessing
    }
}
