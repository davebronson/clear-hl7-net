namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0062 - Event Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0062</remarks>
    public enum CodeEventReason
    {
        /// <summary>
        /// 01 - Patient request.
        /// </summary>
        PatientRequest,

        /// <summary>
        /// 02 - Physician/health practitioner order.
        /// </summary>
        PhysicianHealthPractitionerOrder,

        /// <summary>
        /// 03 - Census management.
        /// </summary>
        CensusManagement
    }
}
