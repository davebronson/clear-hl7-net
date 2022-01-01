namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0004 - Patient Class .
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0004</remarks>
    public enum CodePatientClass
    {
        /// <summary>
        /// B - Obstetrics.
        /// </summary>
        Obstetrics,

        /// <summary>
        /// E - Emergency.
        /// </summary>
        Emergency,

        /// <summary>
        /// I - Inpatient.
        /// </summary>
        Inpatient,

        /// <summary>
        /// O - Outpatient.
        /// </summary>
        Outpatient,

        /// <summary>
        /// P - Preadmit.
        /// </summary>
        Preadmit,

        /// <summary>
        /// R - Recurring patient.
        /// </summary>
        RecurringPatient
    }
}
