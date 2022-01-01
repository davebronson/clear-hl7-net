namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0305 - Person Location Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0305</remarks>
    public enum CodePersonLocationType
    {
        /// <summary>
        /// C - Clinic.
        /// </summary>
        Clinic,

        /// <summary>
        /// D - Department.
        /// </summary>
        Department,

        /// <summary>
        /// H - Home.
        /// </summary>
        Home,

        /// <summary>
        /// N - Nursing Unit.
        /// </summary>
        NursingUnit,

        /// <summary>
        /// O - Provider's Office.
        /// </summary>
        ProvidersOffice,

        /// <summary>
        /// P - Phone.
        /// </summary>
        Phone,

        /// <summary>
        /// S - SNF.
        /// </summary>
        Snf
    }
}
