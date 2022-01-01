namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0510 - Blood Product Dispense Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0510</remarks>
    public enum CodeBloodProductDispenseStatus
    {
        /// <summary>
        /// CR - Released into inventory for general availability.
        /// </summary>
        ReleasedIntoInventory,

        /// <summary>
        /// DS - Dispensed to patient location.
        /// </summary>
        DispensedToPatient,

        /// <summary>
        /// PT - Presumed transfused (dispensed and not returned).
        /// </summary>
        PresumedTransfused,

        /// <summary>
        /// RA - Returned unused/no longer needed.
        /// </summary>
        ReturnedUnused,

        /// <summary>
        /// RD - Reserved and ready to dispense.
        /// </summary>
        ReservedAndReadyToDispense,

        /// <summary>
        /// RE - Released (no longer allocated for the patient).
        /// </summary>
        ReleasedNoLongerAllocated,

        /// <summary>
        /// RI - Received into inventory (for specified patient).
        /// </summary>
        ReceivedIntoInventory,

        /// <summary>
        /// RL - Returned unused/keep linked to patient for possible use later.
        /// </summary>
        ReturnedUnusedKeepLinkedToPatient,

        /// <summary>
        /// RQ - Request to dispense blood product.
        /// </summary>
        RequestToDispenseBloodProduct,

        /// <summary>
        /// RS - Reserved (ordered and product allocated for the patient).
        /// </summary>
        Reserved,

        /// <summary>
        /// WA - Wasted (product no longer viable).
        /// </summary>
        Wasted
    }
}
