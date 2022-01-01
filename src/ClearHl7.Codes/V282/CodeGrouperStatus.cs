namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0734 - Grouper Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0734</remarks>
    public enum CodeGrouperStatus
    {
        /// <summary>
        /// 0 - Normal grouping.
        /// </summary>
        NormalGrouping,

        /// <summary>
        /// 1 - Invalid or missing primary diagnosis.
        /// </summary>
        InvalidOrMissingPrimaryDiagnosis,

        /// <summary>
        /// 2 - Diagnosis is not allowed to be primary.
        /// </summary>
        DiagnosisIsNotAllowedToBePrimary,

        /// <summary>
        /// 3 - Data does not fulfill DRG criteria.
        /// </summary>
        DataDoesNotFulfillDrgCriteria,

        /// <summary>
        /// 4 - Invalid age, admission date, date of birth or discharge date.
        /// </summary>
        InvalidAgeAdmissionDateDateOfBirthOrDischargeDate,

        /// <summary>
        /// 5 - Invalid gender.
        /// </summary>
        InvalidGender,

        /// <summary>
        /// 6 - Invalid discharge status.
        /// </summary>
        InvalidDischargeStatus,

        /// <summary>
        /// 7 - Invalid weight ad admission.
        /// </summary>
        InvalidWeightAdAdmission,

        /// <summary>
        /// 8 - Invalid length of stay.
        /// </summary>
        InvalidLengthOfStay,

        /// <summary>
        /// 9 - Invalid field "same day".
        /// </summary>
        InvalidFieldSameDay
    }
}
