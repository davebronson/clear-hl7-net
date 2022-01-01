namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0150 - Certification Patient Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0150</remarks>
    public enum CodeCertificationPatientType
    {
        /// <summary>
        /// ER - Emergency.
        /// </summary>
        Emergency,

        /// <summary>
        /// IPE - Inpatient elective.
        /// </summary>
        InpatientElective,

        /// <summary>
        /// OPE - Outpatient elective.
        /// </summary>
        OutpatientElective,

        /// <summary>
        /// UR - Urgent.
        /// </summary>
        Urgent
    }
}
