namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0322 - Completion Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0322</remarks>
    public enum CodeCompletionStatus
    {
        /// <summary>
        /// CP - Complete.
        /// </summary>
        Complete,

        /// <summary>
        /// NA - Not Administered.
        /// </summary>
        NotAdministered,

        /// <summary>
        /// PA - Partially Administered.
        /// </summary>
        PartiallyAdministered,

        /// <summary>
        /// RE - Refused.
        /// </summary>
        Refused
    }
}
