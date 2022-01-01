namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0273 - Document Availability Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0273</remarks>
    public enum CodeDocumentAvailabilityStatus
    {
        /// <summary>
        /// AV - Available for patient care.
        /// </summary>
        AvailableForPatientCare,

        /// <summary>
        /// CA - Deleted.
        /// </summary>
        Deleted,

        /// <summary>
        /// OB - Obsolete.
        /// </summary>
        Obsolete,

        /// <summary>
        /// UN - Unavailable for patient care.
        /// </summary>
        UnavailableForPatientCare
    }
}
