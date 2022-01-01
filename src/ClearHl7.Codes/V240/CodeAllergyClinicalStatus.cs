namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0438 - Allergy Clinical Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0438</remarks>
    public enum CodeAllergyClinicalStatus
    {
        /// <summary>
        /// C - Confirmed or verified.
        /// </summary>
        ConfirmedOrVerified,

        /// <summary>
        /// D - Doubt raised.
        /// </summary>
        DoubtRaised,

        /// <summary>
        /// E - Erroneous.
        /// </summary>
        Erroneous,

        /// <summary>
        /// I - Confirmed but inactive.
        /// </summary>
        ConfirmedButInactive,

        /// <summary>
        /// P - Pending.
        /// </summary>
        Pending,

        /// <summary>
        /// S - Suspect.
        /// </summary>
        Suspect,

        /// <summary>
        /// U - Unconfirmed.
        /// </summary>
        Unconfirmed
    }
}
