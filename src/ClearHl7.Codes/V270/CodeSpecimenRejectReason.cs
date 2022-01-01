namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0490 - Specimen Reject Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0490</remarks>
    public enum CodeSpecimenRejectReason
    {
        /// <summary>
        /// EX - Expired.
        /// </summary>
        Expired,

        /// <summary>
        /// QS - Quantity not sufficient.
        /// </summary>
        QuantityNotSufficient,

        /// <summary>
        /// RA - Missing patient ID number.
        /// </summary>
        MissingPatientIdNumber,

        /// <summary>
        /// RB - Broken container.
        /// </summary>
        BrokenContainer,

        /// <summary>
        /// RC - Clotting.
        /// </summary>
        Clotting,

        /// <summary>
        /// RD - Missing collection date.
        /// </summary>
        MissingCollectionDate,

        /// <summary>
        /// RE - Missing patient name.
        /// </summary>
        MissingPatientName,

        /// <summary>
        /// RH - Hemolysis.
        /// </summary>
        Hemolysis,

        /// <summary>
        /// RI - Identification problem.
        /// </summary>
        IdentificationProblem,

        /// <summary>
        /// RM - Labeling.
        /// </summary>
        Labeling,

        /// <summary>
        /// RN - Contamination.
        /// </summary>
        Contamination,

        /// <summary>
        /// RP - Missing phlebotomist ID.
        /// </summary>
        MissingPhlebotomistId,

        /// <summary>
        /// RR - Improper storage.
        /// </summary>
        ImproperStorage,

        /// <summary>
        /// RS - Name misspelling.
        /// </summary>
        NameMisspelling
    }
}
