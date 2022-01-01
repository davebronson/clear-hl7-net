namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0339 - Advanced Beneficiary Notice Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0339</remarks>
    public enum CodeAdvancedBeneficiaryNoticeCode
    {
        /// <summary>
        /// 1 - Service is subject to medical necessity procedures.
        /// </summary>
        ServiceSubjectToMedicalNecessity,

        /// <summary>
        /// 2 - Patient has been informed of responsibility, and agrees to pay for service.
        /// </summary>
        PatientHasBeenInformedAndAgreesToPayForService,

        /// <summary>
        /// 3 - Patient has been informed of responsibility, and asks that the payer be billed.
        /// </summary>
        PatientHasBeenInformedAndAsksThatPayerBeBilled,

        /// <summary>
        /// 4 - Advanced Beneficiary Notice has not been signed.
        /// </summary>
        AdvancedBeneficiaryNoticeHasNotBeenSigned
    }
}
