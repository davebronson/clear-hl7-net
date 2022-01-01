namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0213 - Purge Status Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0213</remarks>
    public enum CodePurgeStatusCode
    {
        /// <summary>
        /// D - The visit is marked for deletion and the user cannot enter new data against it.
        /// </summary>
        VisitMarkedForDeletion,

        /// <summary>
        /// I - The visit is marked inactive and the user cannot enter new data against it.
        /// </summary>
        VisitMarkedInactive,

        /// <summary>
        /// P - Marked for purge.  User is no longer able to update the visit.
        /// </summary>
        MarkedForPurge
    }
}
