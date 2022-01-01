namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0441 - Immunization Registry Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0441</remarks>
    public enum CodeImmunizationRegistryStatus
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
        /// L - Inactive - Lost to follow-up (cancel contract).
        /// </summary>
        InactiveLostToFollowUp,

        /// <summary>
        /// M - Inactive - Moved or gone elsewhere (cancel contract).
        /// </summary>
        InactiveMovedOrGoneElsewhere,

        /// <summary>
        /// O - Other.
        /// </summary>
        Other,

        /// <summary>
        /// P - Inactive - Permanently inactive (Do not reactivate or add new entries to the record).
        /// </summary>
        InactivePermanently,

        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown
    }
}
