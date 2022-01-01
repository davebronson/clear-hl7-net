namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0935 - Process Interruption Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0935</remarks>
    public enum CodeProcessInterruptionReason
    {
        /// <summary>
        /// ASC - Apheresis Software Crash.
        /// </summary>
        ApheresisSoftwareCrash,

        /// <summary>
        /// BSC - Manufacturing Software Crash.
        /// </summary>
        ManufacturingSoftwareCrash,

        /// <summary>
        /// CFT - Couldn't follow through with donation (scared).
        /// </summary>
        CouldntFollowThroughWithDonationScared,

        /// <summary>
        /// DBB - Bathroom.
        /// </summary>
        Bathroom,

        /// <summary>
        /// DCW - Couldn't wait.
        /// </summary>
        CouldntWait,

        /// <summary>
        /// DNI - Phlebotomy Issue.
        /// </summary>
        PhlebotomyIssue,

        /// <summary>
        /// GFE - General Facility Emergency.
        /// </summary>
        GeneralFacilityEmergency,

        /// <summary>
        /// NRG - No reason given, donor decided to stop without giving a reason.
        /// </summary>
        NoReasonGiven,

        /// <summary>
        /// PCD - Phone Call-Donor.
        /// </summary>
        PhoneCallDonor
    }
}
