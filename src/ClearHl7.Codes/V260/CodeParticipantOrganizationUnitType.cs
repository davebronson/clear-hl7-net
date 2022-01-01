namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0406 - Participant Organization Unit Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0406</remarks>
    public enum CodeParticipantOrganizationUnitType
    {
        /// <summary>
        /// 1 - Hospital.
        /// </summary>
        Hospital,

        /// <summary>
        /// 2 - Physician Clinic.
        /// </summary>
        PhysicianClinic,

        /// <summary>
        /// 3 - Long Term Care.
        /// </summary>
        LongTermCare,

        /// <summary>
        /// 4 - Acute Care.
        /// </summary>
        AcuteCare,

        /// <summary>
        /// 5 - Other.
        /// </summary>
        Other,

        /// <summary>
        /// H - Home.
        /// </summary>
        Home,

        /// <summary>
        /// O - Office.
        /// </summary>
        Office
    }
}
