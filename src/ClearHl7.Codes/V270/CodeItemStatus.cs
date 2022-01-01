namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0776 - Item Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0776</remarks>
    public enum CodeItemStatus
    {
        /// <summary>
        /// A - Active.
        /// </summary>
        Active,

        /// <summary>
        /// I - Inactive.
        /// </summary>
        Inactive,

        /// <summary>
        /// P - Pending Inactive.
        /// </summary>
        PendingInactive
    }
}
