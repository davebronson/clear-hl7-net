namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0315 - Living Will Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0315</remarks>
    public enum CodeLivingWillCode
    {
        /// <summary>
        /// F - Yes, patient has a living will but it is not on file.
        /// </summary>
        YesPatientHasLivingWillButNotOnFile,

        /// <summary>
        /// I - No, patient does not have a living will but information was provided.
        /// </summary>
        NoPatientDoesNotHaveLivingWillButInfoWasProvided,

        /// <summary>
        /// N - No, patient does not have a living will and no information was provided.
        /// </summary>
        NoPatientDoesNotHaveLivingWillAndNoInfoWasProvided,

        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// Y - Yes, patient has a living will.
        /// </summary>
        YesPatientHasLivingWill
    }
}
