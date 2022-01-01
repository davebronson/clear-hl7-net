namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0369 - Specimen Role.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0369</remarks>
    public enum CodeSpecimenRole
    {
        /// <summary>
        /// B - Blind Sample.
        /// </summary>
        BlindSample,

        /// <summary>
        /// C - Calibrator, used for initial setting of calibration.
        /// </summary>
        Calibrator,

        /// <summary>
        /// E - Electronic QC, used with manufactured reference providing signals that simulate QC results.
        /// </summary>
        ElectronicQc,

        /// <summary>
        /// F - Specimen used for testing proficiency of the organization performing the testing (Filler).
        /// </summary>
        SpecimenUsedForTestingProficiency,

        /// <summary>
        /// G - Group (where a specimen consists of multiple individual elements that are not individually identified).
        /// </summary>
        Group,

        /// <summary>
        /// L - Pool (aliquots of individual specimens combined to form a single specimen representing all of the components.).
        /// </summary>
        Pool,

        /// <summary>
        /// O - Specimen used for testing Operator Proficiency.
        /// </summary>
        SpecimenUsedForTestingOperatorProficiency,

        /// <summary>
        /// P - Patient (default if blank component value).
        /// </summary>
        Patient,

        /// <summary>
        /// Q - Control specimen.
        /// </summary>
        ControlSpecimen,

        /// <summary>
        /// R - Replicate (of patient sample as a control).
        /// </summary>
        Replicate,

        /// <summary>
        /// V - Verifying Calibrator, used for periodic calibration checks.
        /// </summary>
        VerifyingCalibrator
    }
}
