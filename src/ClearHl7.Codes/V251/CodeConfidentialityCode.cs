namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0177 - Confidentiality Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0177</remarks>
    public enum CodeConfidentialityCode
    {
        /// <summary>
        /// AID - AIDS patient.
        /// </summary>
        AidsPatient,

        /// <summary>
        /// EMP - Employee.
        /// </summary>
        Employee,

        /// <summary>
        /// ETH - Alcohol/drug treatment patient.
        /// </summary>
        AlcoholDrugTreatmentPatient,

        /// <summary>
        /// HIV - HIV(+) patient.
        /// </summary>
        HivPatient,

        /// <summary>
        /// PSY - Psychiatric patient.
        /// </summary>
        PsychiatricPatient,

        /// <summary>
        /// R - Restricted.
        /// </summary>
        Restricted,

        /// <summary>
        /// U - Usual control.
        /// </summary>
        UsualControl,

        /// <summary>
        /// UWM - Unwed mother.
        /// </summary>
        UnwedMother,

        /// <summary>
        /// V - Very restricted.
        /// </summary>
        VeryRestricted,

        /// <summary>
        /// VIP - Very important person or celebrity.
        /// </summary>
        VeryImportantPersonOrCelebrity
    }
}
