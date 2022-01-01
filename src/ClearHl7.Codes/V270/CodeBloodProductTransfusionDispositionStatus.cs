namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0513 - Blood Product Transfusion/Disposition Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0513</remarks>
    public enum CodeBloodProductTransfusionDispositionStatus
    {
        /// <summary>
        /// RA - Returned unused/no longer needed.
        /// </summary>
        ReturnedUnused,

        /// <summary>
        /// RL - Returned unused/keep linked to patient for possible use later.
        /// </summary>
        ReturnedUnusedKeepLinkedToPatient,

        /// <summary>
        /// TR - Transfused with adverse reaction.
        /// </summary>
        TransfusedWithAdverseReaction,

        /// <summary>
        /// TX - Transfused.
        /// </summary>
        Transfused,

        /// <summary>
        /// WA - Wasted (product no longer viable).
        /// </summary>
        Wasted
    }
}
