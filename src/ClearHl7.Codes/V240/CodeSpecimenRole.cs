namespace ClearHl7.Codes.V240
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
        Replicate
    }
}
