namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0427 - Risk Management Incident Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0427</remarks>
    public enum CodeRiskManagementIncidentCode
    {
        /// <summary>
        /// B - Body fluid exposure.
        /// </summary>
        BodyFluidExposure,

        /// <summary>
        /// C - Contaminated Substance.
        /// </summary>
        ContaminatedSubstance,

        /// <summary>
        /// D - Diet Errors.
        /// </summary>
        DietErrors,

        /// <summary>
        /// E - Equipment problem.
        /// </summary>
        EquipmentProblem,

        /// <summary>
        /// F - Patient fell (not from bed).
        /// </summary>
        PatientFellNotFromBed,

        /// <summary>
        /// H - Patient fell from bed.
        /// </summary>
        PatientFellFromBed,

        /// <summary>
        /// I - Infusion error.
        /// </summary>
        InfusionError,

        /// <summary>
        /// J - Foreign object left during surgery.
        /// </summary>
        ForeignObjectLeftDuringSurgery,

        /// <summary>
        /// K - Sterile precaution violated.
        /// </summary>
        SterilePrecautionViolated,

        /// <summary>
        /// O - Other.
        /// </summary>
        Other,

        /// <summary>
        /// P - Procedure error.
        /// </summary>
        ProcedureError,

        /// <summary>
        /// R - Pharmaceutical error.
        /// </summary>
        PharmaceuticalError,

        /// <summary>
        /// S - Suicide Attempt.
        /// </summary>
        SuicideAttempt,

        /// <summary>
        /// T - Transfusion error.
        /// </summary>
        TransfusionError
    }
}
