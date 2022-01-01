namespace ClearHl7.Codes.V230
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
        /// N - No, patient has not agreed to be a donor.
        /// </summary>
        NoPatientHasNotAgreedToBeDonor,

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
