namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0023 - Admit Source.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0023</remarks>
    public enum CodeAdmitSource
    {
        /// <summary>
        /// 1 - Physician referral.
        /// </summary>
        PhysicianReferral,

        /// <summary>
        /// 2 - Clinic referral.
        /// </summary>
        ClinicReferral,

        /// <summary>
        /// 3 - HMO referral.
        /// </summary>
        HmoReferral,

        /// <summary>
        /// 4 - Transfer from a hospital.
        /// </summary>
        TransferFromHospital,

        /// <summary>
        /// 5 - Transfer from a skilled nursing facility.
        /// </summary>
        TransferFromSkilledNursingFacility,

        /// <summary>
        /// 6 - Transfer from another health care facility.
        /// </summary>
        TransferFromAnotherHealthCareFacility,

        /// <summary>
        /// 7 - Emergency room.
        /// </summary>
        EmergencyRoom,

        /// <summary>
        /// 8 - Court/law enforcement.
        /// </summary>
        CourtLawEnforcement,

        /// <summary>
        /// 9 - Information not available.
        /// </summary>
        InformationNotAvailable
    }
}
