namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0316 - Organ Donor Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0316</remarks>
    public enum CodeOrganDonorCode
    {
        /// <summary>
        /// F - Yes, patient is a documented donor, but documentation is not on file.
        /// </summary>
        YesPatientIsDonorButDocumentationNotOnFile,

        /// <summary>
        /// I - No, patient is not a documented donor, but information was provided.
        /// </summary>
        NoPatientIsNotDonorButInfoWasProvided,

        /// <summary>
        /// N - No, patient has not agreed to be a donor.
        /// </summary>
        NoPatientHasNotAgreedToBeDonor,

        /// <summary>
        /// P - Patient leaves organ donation decision to a specific person.
        /// </summary>
        PatientLeavesOrganDonationDecisionToSpecificPerson,

        /// <summary>
        /// R - Patient leaves organ donation decision to relatives.
        /// </summary>
        PatientLeavesOrganDonationDecisionToRelatives,

        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// Y - Yes, patient is a documented donor and documentation is on file.
        /// </summary>
        YesPatientIsDocumentedDonorAndDocumentationIsOnFile
    }
}
