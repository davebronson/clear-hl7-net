namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0475 - Charge Type Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0475</remarks>
    public enum CodeChargeTypeReason
    {
        /// <summary>
        /// 01 - Allergy.
        /// </summary>
        Allergy,

        /// <summary>
        /// 02 - Intolerance.
        /// </summary>
        Intolerance,

        /// <summary>
        /// 03 - Treatment Failure.
        /// </summary>
        TreatmentFailure,

        /// <summary>
        /// 04 - Patient Request.
        /// </summary>
        PatientRequest,

        /// <summary>
        /// 05 - No Exception.
        /// </summary>
        NoException
    }
}
