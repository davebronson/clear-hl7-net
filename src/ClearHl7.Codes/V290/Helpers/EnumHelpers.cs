using System;

namespace ClearHl7.Codes.V290.Helpers
{
    /// <summary>
    /// Static convenience facade for EnumHelper functionality.
    /// For dependency injection scenarios, use EnumHelper with IEnumHelper interface.
    /// </summary>
    public static class EnumHelpers
    {
        private static readonly EnumHelper _instance = new EnumHelper();

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions)"/>
        public static string EnumToCode(CodeAcceptApplicationAcknowledgmentConditions input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAccessRestrictionValue)"/>
        public static string EnumToCode(CodeAccessRestrictionValue input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAcknowledgmentCode)"/>
        public static string EnumToCode(CodeAcknowledgmentCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeActionTakenInResponseToTheEvent)"/>
        public static string EnumToCode(CodeActionTakenInResponseToTheEvent input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeActiveInactive)"/>
        public static string EnumToCode(CodeActiveInactive input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeActPriority)"/>
        public static string EnumToCode(CodeActPriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdditivePreservative)"/>
        public static string EnumToCode(CodeAdditivePreservative input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAddressExpirationReason)"/>
        public static string EnumToCode(CodeAddressExpirationReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAddressType)"/>
        public static string EnumToCode(CodeAddressType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAddressUsage)"/>
        public static string EnumToCode(CodeAddressUsage input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdjustmentAction)"/>
        public static string EnumToCode(CodeAdjustmentAction input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdjustmentCategoryCode)"/>
        public static string EnumToCode(CodeAdjustmentCategoryCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdministrationDevice)"/>
        public static string EnumToCode(CodeAdministrationDevice input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdministrationMethod)"/>
        public static string EnumToCode(CodeAdministrationMethod input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdministrativeSex)"/>
        public static string EnumToCode(CodeAdministrativeSex input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdmissionLevelOfCareCode)"/>
        public static string EnumToCode(CodeAdmissionLevelOfCareCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdmissionType)"/>
        public static string EnumToCode(CodeAdmissionType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdmitSource)"/>
        public static string EnumToCode(CodeAdmitSource input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdvancedBeneficiaryNoticeCode)"/>
        public static string EnumToCode(CodeAdvancedBeneficiaryNoticeCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdvanceDirectiveCode)"/>
        public static string EnumToCode(CodeAdvanceDirectiveCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAlertDeviceCode)"/>
        public static string EnumToCode(CodeAlertDeviceCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAlertLevel)"/>
        public static string EnumToCode(CodeAlertLevel input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAllergenType)"/>
        public static string EnumToCode(CodeAllergenType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAllergyClinicalStatus)"/>
        public static string EnumToCode(CodeAllergyClinicalStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAllergySeverity)"/>
        public static string EnumToCode(CodeAllergySeverity input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAllowSubstitution)"/>
        public static string EnumToCode(CodeAllowSubstitution input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAllowSubstitutionCodes)"/>
        public static string EnumToCode(CodeAllowSubstitutionCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAlternateCharacterSetHandlingScheme)"/>
        public static string EnumToCode(CodeAlternateCharacterSetHandlingScheme input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAlternateCharacterSets)"/>
        public static string EnumToCode(CodeAlternateCharacterSets input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAmbulatoryPaymentClassificationCode)"/>
        public static string EnumToCode(CodeAmbulatoryPaymentClassificationCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAmbulatoryStatus)"/>
        public static string EnumToCode(CodeAmbulatoryStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAmountClass)"/>
        public static string EnumToCode(CodeAmountClass input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAmountType)"/>
        public static string EnumToCode(CodeAmountType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAnalyteRepeatStatus)"/>
        public static string EnumToCode(CodeAnalyteRepeatStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAnnotations)"/>
        public static string EnumToCode(CodeAnnotations input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeApplicationChangeType)"/>
        public static string EnumToCode(CodeApplicationChangeType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAppointmentReasonCodes)"/>
        public static string EnumToCode(CodeAppointmentReasonCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAppointmentTypeCodes)"/>
        public static string EnumToCode(CodeAppointmentTypeCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeApprovingRegulatoryAgency)"/>
        public static string EnumToCode(CodeApprovingRegulatoryAgency input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeArmStick)"/>
        public static string EnumToCode(CodeArmStick input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeArtificialBlood)"/>
        public static string EnumToCode(CodeArtificialBlood input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAssigningAuthority)"/>
        public static string EnumToCode(CodeAssigningAuthority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAssignmentOfBenefits)"/>
        public static string EnumToCode(CodeAssignmentOfBenefits input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAuthorizationMode)"/>
        public static string EnumToCode(CodeAuthorizationMode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBedStatus)"/>
        public static string EnumToCode(CodeBedStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBenefitGroup)"/>
        public static string EnumToCode(CodeBenefitGroup input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBloodProductCode)"/>
        public static string EnumToCode(CodeBloodProductCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBloodProductDispenseStatus)"/>
        public static string EnumToCode(CodeBloodProductDispenseStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBloodProductProcessingRequirements)"/>
        public static string EnumToCode(CodeBloodProductProcessingRequirements input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBloodProductTransfusionDispositionStatus)"/>
        public static string EnumToCode(CodeBloodProductTransfusionDispositionStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBloodUnitType)"/>
        public static string EnumToCode(CodeBloodUnitType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBodyParts)"/>
        public static string EnumToCode(CodeBodyParts input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBodySite)"/>
        public static string EnumToCode(CodeBodySite input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBodySiteModifier)"/>
        public static string EnumToCode(CodeBodySiteModifier input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBolusType)"/>
        public static string EnumToCode(CodeBolusType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBpObservationStatusCodesInterpretation)"/>
        public static string EnumToCode(CodeBpObservationStatusCodesInterpretation input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCalendarAlignment)"/>
        public static string EnumToCode(CodeCalendarAlignment input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCaseCategoryCode)"/>
        public static string EnumToCode(CodeCaseCategoryCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCausalityObservations)"/>
        public static string EnumToCode(CodeCausalityObservations input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCclValue)"/>
        public static string EnumToCode(CodeCclValue input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCertificateStatus)"/>
        public static string EnumToCode(CodeCertificateStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCertificationCategoryCode)"/>
        public static string EnumToCode(CodeCertificationCategoryCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCertificationPatientType)"/>
        public static string EnumToCode(CodeCertificationPatientType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCertificationStatus)"/>
        public static string EnumToCode(CodeCertificationStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCertificationTypeCode)"/>
        public static string EnumToCode(CodeCertificationTypeCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeChargeOnIndicator)"/>
        public static string EnumToCode(CodeChargeOnIndicator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeChargeType)"/>
        public static string EnumToCode(CodeChargeType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeChargeTypeReason)"/>
        public static string EnumToCode(CodeChargeTypeReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCheckDigitScheme)"/>
        public static string EnumToCode(CodeCheckDigitScheme input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCommandResponse)"/>
        public static string EnumToCode(CodeCommandResponse input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCommentType)"/>
        public static string EnumToCode(CodeCommentType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCompletionStatus)"/>
        public static string EnumToCode(CodeCompletionStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeComputationType)"/>
        public static string EnumToCode(CodeComputationType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConditionCode)"/>
        public static string EnumToCode(CodeConditionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConfidentiality)"/>
        public static string EnumToCode(CodeConfidentiality input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConfidentialityCode)"/>
        public static string EnumToCode(CodeConfidentialityCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConsentBypassReason)"/>
        public static string EnumToCode(CodeConsentBypassReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConsentDisclosureLevel)"/>
        public static string EnumToCode(CodeConsentDisclosureLevel input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConsentMode)"/>
        public static string EnumToCode(CodeConsentMode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConsentNonDisclosureReason)"/>
        public static string EnumToCode(CodeConsentNonDisclosureReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConsentStatus)"/>
        public static string EnumToCode(CodeConsentStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConsentType)"/>
        public static string EnumToCode(CodeConsentType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeContactRole)"/>
        public static string EnumToCode(CodeContactRole input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeContainerCondition)"/>
        public static string EnumToCode(CodeContainerCondition input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeContainerStatus)"/>
        public static string EnumToCode(CodeContainerStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeContinuationStyleCode)"/>
        public static string EnumToCode(CodeContinuationStyleCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeControlledSubstanceSchedule)"/>
        public static string EnumToCode(CodeControlledSubstanceSchedule input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCoordinationOfBenefits)"/>
        public static string EnumToCode(CodeCoordinationOfBenefits input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCoverageType)"/>
        public static string EnumToCode(CodeCoverageType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCpRangeType)"/>
        public static string EnumToCode(CodeCpRangeType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCumulativeDosageLimitUom)"/>
        public static string EnumToCode(CodeCumulativeDosageLimitUom input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCycleType)"/>
        public static string EnumToCode(CodeCycleType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCyclicEntryExitIndicator)"/>
        public static string EnumToCode(CodeCyclicEntryExitIndicator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDataTypes)"/>
        public static string EnumToCode(CodeDataTypes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDateFormat)"/>
        public static string EnumToCode(CodeDateFormat input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDaysOfTheWeek)"/>
        public static string EnumToCode(CodeDaysOfTheWeek input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDayType)"/>
        public static string EnumToCode(CodeDayType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDegreeLicenseCertificate)"/>
        public static string EnumToCode(CodeDegreeLicenseCertificate input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDenialOrRejectionCode)"/>
        public static string EnumToCode(CodeDenialOrRejectionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDerivedSpecimen)"/>
        public static string EnumToCode(CodeDerivedSpecimen input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDeviceDataState)"/>
        public static string EnumToCode(CodeDeviceDataState input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDeviceStatus)"/>
        public static string EnumToCode(CodeDeviceStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDeviceType)"/>
        public static string EnumToCode(CodeDeviceType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDiagnosisClassification)"/>
        public static string EnumToCode(CodeDiagnosisClassification input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDiagnosisPriority)"/>
        public static string EnumToCode(CodeDiagnosisPriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDiagnosisType)"/>
        public static string EnumToCode(CodeDiagnosisType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDiagnosticServiceSectionId)"/>
        public static string EnumToCode(CodeDiagnosticServiceSectionId input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDietCodeSpecificationType)"/>
        public static string EnumToCode(CodeDietCodeSpecificationType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDisabledPersonCode)"/>
        public static string EnumToCode(CodeDisabledPersonCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDispenseMethod)"/>
        public static string EnumToCode(CodeDispenseMethod input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDispenseType)"/>
        public static string EnumToCode(CodeDispenseType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDocumentAvailabilityStatus)"/>
        public static string EnumToCode(CodeDocumentAvailabilityStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDocumentCompletionStatus)"/>
        public static string EnumToCode(CodeDocumentCompletionStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDocumentConfidentialityStatus)"/>
        public static string EnumToCode(CodeDocumentConfidentialityStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDocumentStorageStatus)"/>
        public static string EnumToCode(CodeDocumentStorageStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDocumentType)"/>
        public static string EnumToCode(CodeDocumentType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDrgDiagnosisDeterminationStatus)"/>
        public static string EnumToCode(CodeDrgDiagnosisDeterminationStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDrgGroupingStatus)"/>
        public static string EnumToCode(CodeDrgGroupingStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDrgPayor)"/>
        public static string EnumToCode(CodeDrgPayor input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDrgProcedureDeterminationStatus)"/>
        public static string EnumToCode(CodeDrgProcedureDeterminationStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDrgProcedureRelevance)"/>
        public static string EnumToCode(CodeDrgProcedureRelevance input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDrgStatusFinancialCalculation)"/>
        public static string EnumToCode(CodeDrgStatusFinancialCalculation input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDrgStatusPatient)"/>
        public static string EnumToCode(CodeDrgStatusPatient input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDrgStatusRespirationMinutes)"/>
        public static string EnumToCode(CodeDrgStatusRespirationMinutes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDurationCategories)"/>
        public static string EnumToCode(CodeDurationCategories input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEligibilitySource)"/>
        public static string EnumToCode(CodeEligibilitySource input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEmploymentStatus)"/>
        public static string EnumToCode(CodeEmploymentStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEncoding)"/>
        public static string EnumToCode(CodeEncoding input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEquipmentState)"/>
        public static string EnumToCode(CodeEquipmentState input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeErrorSeverity)"/>
        public static string EnumToCode(CodeErrorSeverity input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEscortRequired)"/>
        public static string EnumToCode(CodeEscortRequired input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEthnicGroup)"/>
        public static string EnumToCode(CodeEthnicGroup input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventConsequence)"/>
        public static string EnumToCode(CodeEventConsequence input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventExpected)"/>
        public static string EnumToCode(CodeEventExpected input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventQualification)"/>
        public static string EnumToCode(CodeEventQualification input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventReason)"/>
        public static string EnumToCode(CodeEventReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventRelatedPeriod)"/>
        public static string EnumToCode(CodeEventRelatedPeriod input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventReportedTo)"/>
        public static string EnumToCode(CodeEventReportedTo input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventSeriousness)"/>
        public static string EnumToCode(CodeEventSeriousness input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventType)"/>
        public static string EnumToCode(CodeEventType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventTypeCode)"/>
        public static string EnumToCode(CodeEventTypeCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeExclusiveTest)"/>
        public static string EnumToCode(CodeExclusiveTest input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeExpandedYesNoIndicator)"/>
        public static string EnumToCode(CodeExpandedYesNoIndicator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeExtendedPriorityCodes)"/>
        public static string EnumToCode(CodeExtendedPriorityCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeFacilityType)"/>
        public static string EnumToCode(CodeFacilityType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeFileLevelEventCode)"/>
        public static string EnumToCode(CodeFileLevelEventCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeFillerStatusCodes)"/>
        public static string EnumToCode(CodeFillerStatusCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeFormularyStatus)"/>
        public static string EnumToCode(CodeFormularyStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeGestationCategoryCode)"/>
        public static string EnumToCode(CodeGestationCategoryCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeGovernmentReimbursementProgram)"/>
        public static string EnumToCode(CodeGovernmentReimbursementProgram input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeGrouperStatus)"/>
        public static string EnumToCode(CodeGrouperStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeHospitalService)"/>
        public static string EnumToCode(CodeHospitalService input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeIdentifierType)"/>
        public static string EnumToCode(CodeIdentifierType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeIdentityMayBeDivulged)"/>
        public static string EnumToCode(CodeIdentityMayBeDivulged input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeIdentityReliabilityCode)"/>
        public static string EnumToCode(CodeIdentityReliabilityCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeImmunizationRegistryStatus)"/>
        public static string EnumToCode(CodeImmunizationRegistryStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInactiveReasonCode)"/>
        public static string EnumToCode(CodeInactiveReasonCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeIncidentTypeCode)"/>
        public static string EnumToCode(CodeIncidentTypeCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeIndirectExposureMechanism)"/>
        public static string EnumToCode(CodeIndirectExposureMechanism input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInformPersonCode)"/>
        public static string EnumToCode(CodeInformPersonCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInstitutionRelationshipType)"/>
        public static string EnumToCode(CodeInstitutionRelationshipType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInsuranceCompanyContactReason)"/>
        public static string EnumToCode(CodeInsuranceCompanyContactReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeIntendedProcedureType)"/>
        public static string EnumToCode(CodeIntendedProcedureType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInvocationEvent)"/>
        public static string EnumToCode(CodeInvocationEvent input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInvoiceControlCode)"/>
        public static string EnumToCode(CodeInvoiceControlCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInvoiceProcessingResultsStatus)"/>
        public static string EnumToCode(CodeInvoiceProcessingResultsStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInvoiceReasonCodes)"/>
        public static string EnumToCode(CodeInvoiceReasonCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInvoiceType)"/>
        public static string EnumToCode(CodeInvoiceType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeItemImportanceCodes)"/>
        public static string EnumToCode(CodeItemImportanceCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeItemStatus)"/>
        public static string EnumToCode(CodeItemStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeItemStatusCodes)"/>
        public static string EnumToCode(CodeItemStatusCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeItemType)"/>
        public static string EnumToCode(CodeItemType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeJobStatus)"/>
        public static string EnumToCode(CodeJobStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeJurisdictionalBreadth)"/>
        public static string EnumToCode(CodeJurisdictionalBreadth input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeKindOfQuantity)"/>
        public static string EnumToCode(CodeKindOfQuantity input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLaborCalculationType)"/>
        public static string EnumToCode(CodeLaborCalculationType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLanguageAbility)"/>
        public static string EnumToCode(CodeLanguageAbility input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLanguageProficiency)"/>
        public static string EnumToCode(CodeLanguageProficiency input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLevelOfCare)"/>
        public static string EnumToCode(CodeLevelOfCare input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLivingArrangement)"/>
        public static string EnumToCode(CodeLivingArrangement input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLivingDependency)"/>
        public static string EnumToCode(CodeLivingDependency input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLivingWillCode)"/>
        public static string EnumToCode(CodeLivingWillCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLoadStatus)"/>
        public static string EnumToCode(CodeLoadStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLocalRemoteControlState)"/>
        public static string EnumToCode(CodeLocalRemoteControlState input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLocationCharacteristicId)"/>
        public static string EnumToCode(CodeLocationCharacteristicId input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLocationEquipment)"/>
        public static string EnumToCode(CodeLocationEquipment input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLocationRelationshipId)"/>
        public static string EnumToCode(CodeLocationRelationshipId input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLocationServiceCode)"/>
        public static string EnumToCode(CodeLocationServiceCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLotControl)"/>
        public static string EnumToCode(CodeLotControl input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMailClaimParty)"/>
        public static string EnumToCode(CodeMailClaimParty input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMaritalStatus)"/>
        public static string EnumToCode(CodeMaritalStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMarketingBasis)"/>
        public static string EnumToCode(CodeMarketingBasis input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMasterfileActionCode)"/>
        public static string EnumToCode(CodeMasterfileActionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMasterFileIdentifierCode)"/>
        public static string EnumToCode(CodeMasterFileIdentifierCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMatchAlgorithms)"/>
        public static string EnumToCode(CodeMatchAlgorithms input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMatchReason)"/>
        public static string EnumToCode(CodeMatchReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMedicalRoleExecutingPhysician)"/>
        public static string EnumToCode(CodeMedicalRoleExecutingPhysician input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMessageErrorConditionCodes)"/>
        public static string EnumToCode(CodeMessageErrorConditionCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMessageStructure)"/>
        public static string EnumToCode(CodeMessageStructure input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMessageType)"/>
        public static string EnumToCode(CodeMessageType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMessageWaitingPriority)"/>
        public static string EnumToCode(CodeMessageWaitingPriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMfnRecordLevelErrorReturn)"/>
        public static string EnumToCode(CodeMfnRecordLevelErrorReturn input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMilitaryService)"/>
        public static string EnumToCode(CodeMilitaryService input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMilitaryStatus)"/>
        public static string EnumToCode(CodeMilitaryStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMimeTypes)"/>
        public static string EnumToCode(CodeMimeTypes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeModeOfArrivalCode)"/>
        public static string EnumToCode(CodeModeOfArrivalCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeModifyIndicator)"/>
        public static string EnumToCode(CodeModifyIndicator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMoneyOrPercentageIndicator)"/>
        public static string EnumToCode(CodeMoneyOrPercentageIndicator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMoodCodes)"/>
        public static string EnumToCode(CodeMoodCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNameAddressRepresentation)"/>
        public static string EnumToCode(CodeNameAddressRepresentation input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNameAssemblyOrder)"/>
        public static string EnumToCode(CodeNameAssemblyOrder input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNameType)"/>
        public static string EnumToCode(CodeNameType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNatureOfAbnormalTesting)"/>
        public static string EnumToCode(CodeNatureOfAbnormalTesting input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNatureOfChallenge)"/>
        public static string EnumToCode(CodeNatureOfChallenge input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNatureOfServiceTestObservation)"/>
        public static string EnumToCode(CodeNatureOfServiceTestObservation input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNewbornCode)"/>
        public static string EnumToCode(CodeNewbornCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNonSubjectConsenterReason)"/>
        public static string EnumToCode(CodeNonSubjectConsenterReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNotifyClergyCode)"/>
        public static string EnumToCode(CodeNotifyClergyCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeObservationResultHandling)"/>
        public static string EnumToCode(CodeObservationResultHandling input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeObservationResultStatusCodesInterpretation)"/>
        public static string EnumToCode(CodeObservationResultStatusCodesInterpretation input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOccurrenceCode)"/>
        public static string EnumToCode(CodeOccurrenceCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOccurrenceSpan)"/>
        public static string EnumToCode(CodeOccurrenceSpan input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOrderControlCodes)"/>
        public static string EnumToCode(CodeOrderControlCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOrderStatus)"/>
        public static string EnumToCode(CodeOrderStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOrderType)"/>
        public static string EnumToCode(CodeOrderType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOrganDonorCode)"/>
        public static string EnumToCode(CodeOrganDonorCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOrganizationAgencyDepartment)"/>
        public static string EnumToCode(CodeOrganizationAgencyDepartment input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOrganizationalNameType)"/>
        public static string EnumToCode(CodeOrganizationalNameType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOtherEnvironmentalFactors)"/>
        public static string EnumToCode(CodeOtherEnvironmentalFactors input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOutlierType)"/>
        public static string EnumToCode(CodeOutlierType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOverallClaimDispositionCode)"/>
        public static string EnumToCode(CodeOverallClaimDispositionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOverride)"/>
        public static string EnumToCode(CodeOverride input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOverrideType)"/>
        public static string EnumToCode(CodeOverrideType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePackage)"/>
        public static string EnumToCode(CodePackage input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePackagingStatusCode)"/>
        public static string EnumToCode(CodePackagingStatusCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeParticipantOrganizationUnitType)"/>
        public static string EnumToCode(CodeParticipantOrganizationUnitType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeParticipation)"/>
        public static string EnumToCode(CodeParticipation input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientClass)"/>
        public static string EnumToCode(CodePatientClass input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientConditionCode)"/>
        public static string EnumToCode(CodePatientConditionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientLocationType)"/>
        public static string EnumToCode(CodePatientLocationType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientOutcome)"/>
        public static string EnumToCode(CodePatientOutcome input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientResultsReleaseCategorizationScheme)"/>
        public static string EnumToCode(CodePatientResultsReleaseCategorizationScheme input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientsRelationshiptoInsured)"/>
        public static string EnumToCode(CodePatientsRelationshiptoInsured input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientStatusCode)"/>
        public static string EnumToCode(CodePatientStatusCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePayeeRelationshipToInvoice)"/>
        public static string EnumToCode(CodePayeeRelationshipToInvoice input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePayeeType)"/>
        public static string EnumToCode(CodePayeeType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePaymentAdjustmentCode)"/>
        public static string EnumToCode(CodePaymentAdjustmentCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePaymentMethodCode)"/>
        public static string EnumToCode(CodePaymentMethodCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePcaType)"/>
        public static string EnumToCode(CodePcaType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePersonLocationType)"/>
        public static string EnumToCode(CodePersonLocationType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePharmacyOrderTypes)"/>
        public static string EnumToCode(CodePharmacyOrderTypes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePhlebotomyIssue)"/>
        public static string EnumToCode(CodePhlebotomyIssue input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePhlebotomyStatus)"/>
        public static string EnumToCode(CodePhlebotomyStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePolicyType)"/>
        public static string EnumToCode(CodePolicyType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePractitionerIdNumberType)"/>
        public static string EnumToCode(CodePractitionerIdNumberType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePractitionerOrganizationUnitType)"/>
        public static string EnumToCode(CodePractitionerOrganizationUnitType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePrecautionCode)"/>
        public static string EnumToCode(CodePrecautionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePreferredMethodOfContact)"/>
        public static string EnumToCode(CodePreferredMethodOfContact input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePreferredSpecimenAttributeStatus)"/>
        public static string EnumToCode(CodePreferredSpecimenAttributeStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePriceType)"/>
        public static string EnumToCode(CodePriceType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePrimaryKeyValueType)"/>
        public static string EnumToCode(CodePrimaryKeyValueType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePrimaryObserversQualification)"/>
        public static string EnumToCode(CodePrimaryObserversQualification input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePriority)"/>
        public static string EnumToCode(CodePriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePrivacyLevel)"/>
        public static string EnumToCode(CodePrivacyLevel input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProblemGoalActionCode)"/>
        public static string EnumToCode(CodeProblemGoalActionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcedureDrgType)"/>
        public static string EnumToCode(CodeProcedureDrgType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcedureFunctionalType)"/>
        public static string EnumToCode(CodeProcedureFunctionalType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcedurePriority)"/>
        public static string EnumToCode(CodeProcedurePriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcessingConsiderationCodes)"/>
        public static string EnumToCode(CodeProcessingConsiderationCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcessingId)"/>
        public static string EnumToCode(CodeProcessingId input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcessingMode)"/>
        public static string EnumToCode(CodeProcessingMode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcessingPriority)"/>
        public static string EnumToCode(CodeProcessingPriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcessingType)"/>
        public static string EnumToCode(CodeProcessingType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcessInterruption)"/>
        public static string EnumToCode(CodeProcessInterruption input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcessInterruptionReason)"/>
        public static string EnumToCode(CodeProcessInterruptionReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProductionClassCode)"/>
        public static string EnumToCode(CodeProductionClassCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProductServicesClarificationCodes)"/>
        public static string EnumToCode(CodeProductServicesClarificationCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProductServiceStatus)"/>
        public static string EnumToCode(CodeProductServiceStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProductSource)"/>
        public static string EnumToCode(CodeProductSource input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProtectionCode)"/>
        public static string EnumToCode(CodeProtectionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProviderAdjustmentReasonCode)"/>
        public static string EnumToCode(CodeProviderAdjustmentReasonCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProviderBilling)"/>
        public static string EnumToCode(CodeProviderBilling input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProviderRole)"/>
        public static string EnumToCode(CodeProviderRole input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePublicityCode)"/>
        public static string EnumToCode(CodePublicityCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePurgeStatusCode)"/>
        public static string EnumToCode(CodePurgeStatusCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeQuantityLimitedRequest)"/>
        public static string EnumToCode(CodeQuantityLimitedRequest input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeQuantityMethod)"/>
        public static string EnumToCode(CodeQuantityMethod input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeQueryPriority)"/>
        public static string EnumToCode(CodeQueryPriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeQueryResponseStatus)"/>
        public static string EnumToCode(CodeQueryResponseStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRace)"/>
        public static string EnumToCode(CodeRace input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReadmissionIndicator)"/>
        public static string EnumToCode(CodeReadmissionIndicator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRecreationalDrugUseCode)"/>
        public static string EnumToCode(CodeRecreationalDrugUseCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReferralCategory)"/>
        public static string EnumToCode(CodeReferralCategory input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReferralDisposition)"/>
        public static string EnumToCode(CodeReferralDisposition input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReferralPriority)"/>
        public static string EnumToCode(CodeReferralPriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReferralReason)"/>
        public static string EnumToCode(CodeReferralReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReferralStatus)"/>
        public static string EnumToCode(CodeReferralStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReferralType)"/>
        public static string EnumToCode(CodeReferralType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReimbursementActionCode)"/>
        public static string EnumToCode(CodeReimbursementActionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReimbursementTypeCode)"/>
        public static string EnumToCode(CodeReimbursementTypeCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelatednessAssessment)"/>
        public static string EnumToCode(CodeRelatednessAssessment input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelationalConjunction)"/>
        public static string EnumToCode(CodeRelationalConjunction input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelationalOperator)"/>
        public static string EnumToCode(CodeRelationalOperator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelationship)"/>
        public static string EnumToCode(CodeRelationship input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelationshipModifier)"/>
        public static string EnumToCode(CodeRelationshipModifier input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelevantClinicialInformation)"/>
        public static string EnumToCode(CodeRelevantClinicialInformation input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReligion)"/>
        public static string EnumToCode(CodeReligion input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRemoteControlCommand)"/>
        public static string EnumToCode(CodeRemoteControlCommand input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReorderTheoryCodes)"/>
        public static string EnumToCode(CodeReorderTheoryCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRepeatPattern)"/>
        public static string EnumToCode(CodeRepeatPattern input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReportingPriority)"/>
        public static string EnumToCode(CodeReportingPriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReportSource)"/>
        public static string EnumToCode(CodeReportSource input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReportTiming)"/>
        public static string EnumToCode(CodeReportTiming input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeResponseFlag)"/>
        public static string EnumToCode(CodeResponseFlag input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeResponseLevel)"/>
        public static string EnumToCode(CodeResponseLevel input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeResponseModality)"/>
        public static string EnumToCode(CodeResponseModality input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeResultStatus)"/>
        public static string EnumToCode(CodeResultStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRevenueCode)"/>
        public static string EnumToCode(CodeRevenueCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRiskCodes)"/>
        public static string EnumToCode(CodeRiskCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRiskManagementIncidentCode)"/>
        public static string EnumToCode(CodeRiskManagementIncidentCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRoleExecutingPhysician)"/>
        public static string EnumToCode(CodeRoleExecutingPhysician input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRoomType)"/>
        public static string EnumToCode(CodeRoomType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRootCause)"/>
        public static string EnumToCode(CodeRootCause input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRouteOfAdministration)"/>
        public static string EnumToCode(CodeRouteOfAdministration input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRulingAct)"/>
        public static string EnumToCode(CodeRulingAct input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRXComponentType)"/>
        public static string EnumToCode(CodeRXComponentType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSchoolType)"/>
        public static string EnumToCode(CodeSchoolType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSecurityCheckScheme)"/>
        public static string EnumToCode(CodeSecurityCheckScheme input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSegmentActionCode)"/>
        public static string EnumToCode(CodeSegmentActionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSegmentGroup)"/>
        public static string EnumToCode(CodeSegmentGroup input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSensitivityToCausativeAgentCode)"/>
        public static string EnumToCode(CodeSensitivityToCausativeAgentCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSequenceConditionCode)"/>
        public static string EnumToCode(CodeSequenceConditionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSequenceResultsFlag)"/>
        public static string EnumToCode(CodeSequenceResultsFlag input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSequencing)"/>
        public static string EnumToCode(CodeSequencing input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeServiceRequestRelationship)"/>
        public static string EnumToCode(CodeServiceRequestRelationship input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSeverityOfIllnessCode)"/>
        public static string EnumToCode(CodeSeverityOfIllnessCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeShipmentStatus)"/>
        public static string EnumToCode(CodeShipmentStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSideOfBody)"/>
        public static string EnumToCode(CodeSideOfBody input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSignatorysRelationshipToSubject)"/>
        public static string EnumToCode(CodeSignatorysRelationshipToSubject input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSignatureCode)"/>
        public static string EnumToCode(CodeSignatureCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSourceOfComment)"/>
        public static string EnumToCode(CodeSourceOfComment input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSourceType)"/>
        public static string EnumToCode(CodeSourceType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecialHandlingCode)"/>
        public static string EnumToCode(CodeSpecialHandlingCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecialProgramCode)"/>
        public static string EnumToCode(CodeSpecialProgramCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecialtyType)"/>
        public static string EnumToCode(CodeSpecialtyType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenActionCode)"/>
        public static string EnumToCode(CodeSpecimenActionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenAppropriateness)"/>
        public static string EnumToCode(CodeSpecimenAppropriateness input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenChildRole)"/>
        public static string EnumToCode(CodeSpecimenChildRole input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenCollectionMethod)"/>
        public static string EnumToCode(CodeSpecimenCollectionMethod input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenComponent)"/>
        public static string EnumToCode(CodeSpecimenComponent input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenCondition)"/>
        public static string EnumToCode(CodeSpecimenCondition input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenQuality)"/>
        public static string EnumToCode(CodeSpecimenQuality input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenRejectReason)"/>
        public static string EnumToCode(CodeSpecimenRejectReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenRole)"/>
        public static string EnumToCode(CodeSpecimenRole input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenType)"/>
        public static string EnumToCode(CodeSpecimenType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeStatusAdmission)"/>
        public static string EnumToCode(CodeStatusAdmission input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeStatusOfEvaluation)"/>
        public static string EnumToCode(CodeStatusOfEvaluation input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeStatusWeightAtBirth)"/>
        public static string EnumToCode(CodeStatusWeightAtBirth input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSterilizationType)"/>
        public static string EnumToCode(CodeSterilizationType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeStudentStatus)"/>
        public static string EnumToCode(CodeStudentStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSubstanceStatus)"/>
        public static string EnumToCode(CodeSubstanceStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSubstanceType)"/>
        public static string EnumToCode(CodeSubstanceType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSubstitutionStatus)"/>
        public static string EnumToCode(CodeSubstitutionStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSubtypeOfReferencedData)"/>
        public static string EnumToCode(CodeSubtypeOfReferencedData input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSupplementalServiceInformationValues)"/>
        public static string EnumToCode(CodeSupplementalServiceInformationValues input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSupplyRiskCodes)"/>
        public static string EnumToCode(CodeSupplyRiskCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSystemInducedContaminants)"/>
        public static string EnumToCode(CodeSystemInducedContaminants input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTaxStatus)"/>
        public static string EnumToCode(CodeTaxStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTelecommunicationEquipmentType)"/>
        public static string EnumToCode(CodeTelecommunicationEquipmentType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTelecommunicationExpirationReason)"/>
        public static string EnumToCode(CodeTelecommunicationExpirationReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTelecommunicationUseCode)"/>
        public static string EnumToCode(CodeTelecommunicationUseCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTimeDelayPostChallenge)"/>
        public static string EnumToCode(CodeTimeDelayPostChallenge input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTimeSelectionCriteriaParameterClassCodes)"/>
        public static string EnumToCode(CodeTimeSelectionCriteriaParameterClassCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTissueTypeCode)"/>
        public static string EnumToCode(CodeTissueTypeCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTqConjunctionId)"/>
        public static string EnumToCode(CodeTqConjunctionId input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTransactionType)"/>
        public static string EnumToCode(CodeTransactionType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTransferType)"/>
        public static string EnumToCode(CodeTransferType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTransfusionAdverseReaction)"/>
        public static string EnumToCode(CodeTransfusionAdverseReaction input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTransportArranged)"/>
        public static string EnumToCode(CodeTransportArranged input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTransportationMode)"/>
        public static string EnumToCode(CodeTransportationMode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTrayType)"/>
        public static string EnumToCode(CodeTrayType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTreatment)"/>
        public static string EnumToCode(CodeTreatment input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTriageCode)"/>
        public static string EnumToCode(CodeTriageCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTypeOfAgreement)"/>
        public static string EnumToCode(CodeTypeOfAgreement input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTypeOfBillCode)"/>
        public static string EnumToCode(CodeTypeOfBillCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTypeOfReferencedData)"/>
        public static string EnumToCode(CodeTypeOfReferencedData input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeUniversalIdType)"/>
        public static string EnumToCode(CodeUniversalIdType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeUserAuthenticationCredentialTypeCode)"/>
        public static string EnumToCode(CodeUserAuthenticationCredentialTypeCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeValueType)"/>
        public static string EnumToCode(CodeValueType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeVersionId)"/>
        public static string EnumToCode(CodeVersionId input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeVisitIndicator)"/>
        public static string EnumToCode(CodeVisitIndicator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeVisitPriorityCode)"/>
        public static string EnumToCode(CodeVisitPriorityCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeVisitUserCode)"/>
        public static string EnumToCode(CodeVisitUserCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeYesNoIndicator)"/>
        public static string EnumToCode(CodeYesNoIndicator input)
            => _instance.EnumToCode(input);
    }
}
