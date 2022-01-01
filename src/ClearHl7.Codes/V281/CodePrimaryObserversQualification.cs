namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0242 - Primary Observer's Qualification.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0242</remarks>
    public enum CodePrimaryObserversQualification
    {
        /// <summary>
        /// C - Health care consumer/patient.
        /// </summary>
        HealthCareConsumerPatient,

        /// <summary>
        /// H - Other health professional.
        /// </summary>
        OtherHealthProfessional,

        /// <summary>
        /// L - Lawyer/attorney.
        /// </summary>
        LawyerAttorney,

        /// <summary>
        /// M - Mid-level professional (nurse, nurse practitioner, physician's assistant).
        /// </summary>
        MidLevelProfessional,

        /// <summary>
        /// O - Other non-health professional.
        /// </summary>
        OtherNonHealthProfessional,

        /// <summary>
        /// P - Physician (osteopath, homeopath).
        /// </summary>
        PhysicianOsteopathHomeopath,

        /// <summary>
        /// R - Pharmacist.
        /// </summary>
        Pharmacist
    }
}
