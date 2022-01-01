namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0484 - Dispense Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0484</remarks>
    public enum CodeDispenseType
    {
        /// <summary>
        /// B - Trial Quantity Balance.
        /// </summary>
        TrialQuantityBalance,

        /// <summary>
        /// C - Compassionate Fill.
        /// </summary>
        CompassionateFill,

        /// <summary>
        /// N - New/Renew - Full Fill.
        /// </summary>
        NewRenewFullFill,

        /// <summary>
        /// P - New/Renew - Part Fill.
        /// </summary>
        NewRenewPartFill,

        /// <summary>
        /// Q - Refill - Part Fill.
        /// </summary>
        RefillPartFill,

        /// <summary>
        /// R - Refill - Full Fill.
        /// </summary>
        RefillFullFill,

        /// <summary>
        /// S - Manufacturer Sample.
        /// </summary>
        ManufacturerSample,

        /// <summary>
        /// T - Trial Quantity.
        /// </summary>
        TrialQuantity,

        /// <summary>
        /// Z - Non-Prescription Fill.
        /// </summary>
        NonPrescriptionFill
    }
}
