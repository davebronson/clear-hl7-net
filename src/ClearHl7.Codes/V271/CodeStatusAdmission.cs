namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0759 - Status Admission.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0759</remarks>
    public enum CodeStatusAdmission
    {
        /// <summary>
        /// 0 - Admission status is valid; used for grouping.
        /// </summary>
        AdmissionStatusIsValidUsedForGrouping,

        /// <summary>
        /// 1 - Admission status is valid; not used for grouping.
        /// </summary>
        AdmissionStatusIsValidNotUsedForGrouping,

        /// <summary>
        /// 2 - Admission status is invalid; not used for grouping.
        /// </summary>
        AdmissionStatusIsInvalidNotUsedForGrouping,

        /// <summary>
        /// 3 - Admission status is invalid; default value used for grouping.
        /// </summary>
        AdmissionStatusIsInvalidDefaultValueUsedForGrouping
    }
}
