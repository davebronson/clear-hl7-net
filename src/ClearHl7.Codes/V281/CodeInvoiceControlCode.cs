namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0553 - Invoice Control Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0553</remarks>
    public enum CodeInvoiceControlCode
    {
        /// <summary>
        /// AA - Authorization request for inpatient admission.
        /// </summary>
        AuthorizationRequestForAdmission,

        /// <summary>
        /// AI - Combined Authorization and Adjudication request.
        /// </summary>
        CombinedAuthorizationAndAdjudicationRequest,

        /// <summary>
        /// CA - Cancel Authorization request.
        /// </summary>
        CancelAuthorizationRequest,

        /// <summary>
        /// CG - Cancel Invoice Product/Service Group.
        /// </summary>
        CancelInvoiceProductServiceGroup,

        /// <summary>
        /// CL - Cancel Invoice Product/Service Line Item.
        /// </summary>
        CancelInvoiceProductServiceLineItem,

        /// <summary>
        /// CN - Cancel Invoice.
        /// </summary>
        CancelInvoice,

        /// <summary>
        /// CP - Copy of Invoice.
        /// </summary>
        CopyOfInvoice,

        /// <summary>
        /// CQ - Coverage Register Query.
        /// </summary>
        CoverageRegisterQuery,

        /// <summary>
        /// EA - Authorization request for inpatient stay extension.
        /// </summary>
        AuthorizationRequestForInpatientStayExtension,

        /// <summary>
        /// OA - Original Authorization.
        /// </summary>
        OriginalAuthorization,

        /// <summary>
        /// OR - Original Invoice.
        /// </summary>
        OriginalInvoice,

        /// <summary>
        /// PA - Pre-Authorization.
        /// </summary>
        PreAuthorization,

        /// <summary>
        /// PD - Pre-Determination Invoice.
        /// </summary>
        PreDeterminationInvoice,

        /// <summary>
        /// RA - Re-Assessment.
        /// </summary>
        ReAssessment,

        /// <summary>
        /// RC - Referral Pre-Authorization.
        /// </summary>
        ReferralPreAuthorization,

        /// <summary>
        /// RU - Referral authorization.
        /// </summary>
        ReferralAuthorization,

        /// <summary>
        /// SA - Special Authorization.
        /// </summary>
        SpecialAuthorization
    }
}
