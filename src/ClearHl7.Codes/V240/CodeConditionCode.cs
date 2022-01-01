namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0043 - Condition Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0043</remarks>
    public enum CodeConditionCode
    {
        /// <summary>
        /// 01 - Military service related.
        /// </summary>
        MilitaryServiceRelated,

        /// <summary>
        /// 02 - Condition is employment related.
        /// </summary>
        ConditionIsEmploymentRelated,

        /// <summary>
        /// 03 - Patient covered by insurance not reflected here.
        /// </summary>
        PatientCoveredByInsuranceNotReflectedHere,

        /// <summary>
        /// 04 - HMO enrollee.
        /// </summary>
        HmoEnrollee,

        /// <summary>
        /// 05 - Lien has been filed.
        /// </summary>
        LienHasBeenFiled,

        /// <summary>
        /// 06 - ESRD patient in first 18 months of entitlement covered by employer group health insurance.
        /// </summary>
        EsrdPatient18MonthsCoveredByEmployerInsurance,

        /// <summary>
        /// 07 - Treatment of non-terminal condition for hospice patient.
        /// </summary>
        TreatmentOfNonTerminalConditionHospicePatient,

        /// <summary>
        /// 08 - Beneficiary would not provide information concerning other insurance coverage.
        /// </summary>
        BeneficiaryWouldNotProvideInfoConcerningOtherInsurance,

        /// <summary>
        /// 09 - Neither patient nor spouse is employed.
        /// </summary>
        NeitherPatientNorSpouseIsEmployed,

        /// <summary>
        /// 10 - Patient and/or spouse is employed but no EGHP exists.
        /// </summary>
        PatientAndOrSpouseIsEmployedButNoEghpExists,

        /// <summary>
        /// 11 - Disabled beneficiary but no LGHP.
        /// </summary>
        DisabledBeneficiaryButNoLghp,

        /// <summary>
        /// 12 - Payer codes.
        /// </summary>
        PayerCodes12,

        /// <summary>
        /// 12 ... 16 - Payer codes.
        /// </summary>
        PayerCodes12To16,

        /// <summary>
        /// 13 - Payer codes.
        /// </summary>
        PayerCodes13,

        /// <summary>
        /// 14 - Payer codes.
        /// </summary>
        PayerCodes14,

        /// <summary>
        /// 15 - Payer codes.
        /// </summary>
        PayerCodes15,

        /// <summary>
        /// 16 - Payer codes.
        /// </summary>
        PayerCodes16,

        /// <summary>
        /// 18 - Maiden name retained.
        /// </summary>
        MaidenNameRetained,

        /// <summary>
        /// 19 - Child retains mother's name.
        /// </summary>
        ChildRetainsMothersName,

        /// <summary>
        /// 20 - Beneficiary requested billing.
        /// </summary>
        BeneficiaryRequestedBilling,

        /// <summary>
        /// 21 - Billing for Denial Notice.
        /// </summary>
        BillingForDenialNotice,

        /// <summary>
        /// 26 - VA eligible patient chooses to receive services in a Medicare certified facility.
        /// </summary>
        VaPatientChoosesMedicareCertifiedFacility,

        /// <summary>
        /// 27 - Patient referred to a sole community hospital for a diagnostic laboratory test.
        /// </summary>
        PatientReferredToHospitalForDiagnosticLabTest,

        /// <summary>
        /// 28 - Patient and/or spouse's EGHP is secondary to Medicare.
        /// </summary>
        PatientAndOrSpousesEghpIsSecondaryToMedicare,

        /// <summary>
        /// 29 - Disabled beneficiary and/or family member's LGHP is secondary to Medicare.
        /// </summary>
        DisabledBeneficiaryAndOrFamilyMembersLghpIsSecondaryToMedicare,

        /// <summary>
        /// 31 - Patient is student (full time-day).
        /// </summary>
        PatientIsStudentFullTimeDay,

        /// <summary>
        /// 32 - Patient is student (cooperative/work study program).
        /// </summary>
        PatientIsStudentWorkStudyProgram,

        /// <summary>
        /// 33 - Patient is student (full time-night).
        /// </summary>
        PatientIsStudentFullTimeNight,

        /// <summary>
        /// 34 - Patient is student (Part time).
        /// </summary>
        PatientIsStudentPartTime,

        /// <summary>
        /// 36 - General care patient in a special unit.
        /// </summary>
        GeneralCarePatientInSpecialUnit,

        /// <summary>
        /// 37 - Ward accommodation as patient request.
        /// </summary>
        WardAccommodationAsPatientRequest,

        /// <summary>
        /// 38 - Semi-private room not available.
        /// </summary>
        SemiPrivateRoomNotAvailable,

        /// <summary>
        /// 39 - Private room medically necessary.
        /// </summary>
        PrivateRoomMedicallyNecessary,

        /// <summary>
        /// 40 - Same day transfer.
        /// </summary>
        SameDayTransfer,

        /// <summary>
        /// 41 - Partial hospitalization.
        /// </summary>
        PartialHospitalization,

        /// <summary>
        /// 46 - Non-availability statement on file.
        /// </summary>
        NonAvailabilityStatementOnFile,

        /// <summary>
        /// 48 - Psychiatric residential treatment centers for children and adolescents.
        /// </summary>
        PsycTreatmentCentersForChildrenAndAdolescents,

        /// <summary>
        /// 55 - SNF bed not available.
        /// </summary>
        SnfBedNotAvailable,

        /// <summary>
        /// 56 - Medical appropriateness.
        /// </summary>
        MedicalAppropriateness,

        /// <summary>
        /// 57 - SNF readmission.
        /// </summary>
        SnfReadmission,

        /// <summary>
        /// 60 - Day outlier.
        /// </summary>
        DayOutlier,

        /// <summary>
        /// 61 - Cost outlier.
        /// </summary>
        CostOutlier,

        /// <summary>
        /// 62 - Payer code.
        /// </summary>
        PayerCode,

        /// <summary>
        /// 66 - Provider does not wish cost outlier payment.
        /// </summary>
        ProviderDoesNotWishCostOutlierPayment,

        /// <summary>
        /// 67 - Beneficiary elects not to use life time reserve (LTR) days.
        /// </summary>
        BeneficiaryElectsNotToUseLifeTimeReserveLtrDays,

        /// <summary>
        /// 68 - Beneficiary elects to use life time reserve (LTR) days.
        /// </summary>
        BeneficiaryElectsToUseLifeTimeReserveLtrDays,

        /// <summary>
        /// 70 - Self-administered EPO.
        /// </summary>
        SelfAdministeredEpo,

        /// <summary>
        /// 71 - Full care in unit.
        /// </summary>
        FullCareInUnit,

        /// <summary>
        /// 72 - Self-care in unit.
        /// </summary>
        SelfCareInUnit,

        /// <summary>
        /// 73 - Self-care training.
        /// </summary>
        SelfCareTraining,

        /// <summary>
        /// 74 - Home.
        /// </summary>
        Home,

        /// <summary>
        /// 75 - Home - 100% reimbursement.
        /// </summary>
        Home100Reimbursement,

        /// <summary>
        /// 76 - Back-up in facility dialysis.
        /// </summary>
        BackUpInFacilityDialysis,

        /// <summary>
        /// 77 - Provider accepts or is obligated/required due to a contractual arrangement or law to accept payment by a primary payer as payment in full.
        /// </summary>
        ProviderAcceptsPayerPaymentInFull,

        /// <summary>
        /// 78 - New coverage not implemented by HMO.
        /// </summary>
        NewCoverageNotImplementedByHmo,

        /// <summary>
        /// 79 - Corf services provided off-site.
        /// </summary>
        CorfServicesProvidedOffSite,

        /// <summary>
        /// 80 - Pregnant.
        /// </summary>
        Pregnant
    }
}
