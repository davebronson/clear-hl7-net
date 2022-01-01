namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0480 - Pharmacy Order Types.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0480</remarks>
    public enum CodePharmacyOrderTypes
    {
        /// <summary>
        /// M - Medication.
        /// </summary>
        Medication,

        /// <summary>
        /// O - Other solution as medication orders.
        /// </summary>
        OtherSolutionAsMedicationOrders,

        /// <summary>
        /// S - IV Large Volume Solutions.
        /// </summary>
        IvLargeVolumeSolutions
    }
}
