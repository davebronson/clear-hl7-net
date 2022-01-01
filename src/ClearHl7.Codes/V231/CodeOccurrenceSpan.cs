namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0351 - Occurrence Span.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0351</remarks>
    public enum CodeOccurrenceSpan
    {
        /// <summary>
        /// 70 - Qualifying stay dates for SNF.
        /// </summary>
        QualifyingStayDatesForSnf,

        /// <summary>
        /// 71 - Prior stay dates.
        /// </summary>
        PriorStayDates,

        /// <summary>
        /// 72 - First/last visit.
        /// </summary>
        FirstLastVisit,

        /// <summary>
        /// 73 - Benefit eligibility period.
        /// </summary>
        BenefitEligibilityPeriod,

        /// <summary>
        /// 74 - Non-covered level of care.
        /// </summary>
        NonCoveredLevelOfCare,

        /// <summary>
        /// 75 - SNF level of care.
        /// </summary>
        SnfLevelOfCare,

        /// <summary>
        /// 76 - Patient liability.
        /// </summary>
        PatientLiability,

        /// <summary>
        /// 77 - Provider liability period.
        /// </summary>
        ProviderLiabilityPeriod,

        /// <summary>
        /// 78 - SNF prior stay dates.
        /// </summary>
        SnfPriorStayDates,

        /// <summary>
        /// 79 - Payer code.
        /// </summary>
        PayerCode,

        /// <summary>
        /// M0 - PSRO/UR approved stay dates.
        /// </summary>
        PsroUrApprovedStayDates
    }
}
