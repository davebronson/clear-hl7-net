using System;

namespace ClearHl7.Codes.V231.Helpers
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAcknowledgmentCode)"/>
        public static string EnumToCode(CodeAcknowledgmentCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeActionCode)"/>
        public static string EnumToCode(CodeActionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeActionTakenInResponseToTheEvent)"/>
        public static string EnumToCode(CodeActionTakenInResponseToTheEvent input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeActiveInactive)"/>
        public static string EnumToCode(CodeActiveInactive input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAddressType)"/>
        public static string EnumToCode(CodeAddressType input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdmissionType)"/>
        public static string EnumToCode(CodeAdmissionType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdmitSource)"/>
        public static string EnumToCode(CodeAdmitSource input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAdvancedBeneficiaryNoticeCode)"/>
        public static string EnumToCode(CodeAdvancedBeneficiaryNoticeCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAllergenType)"/>
        public static string EnumToCode(CodeAllergenType input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAmbulatoryStatus)"/>
        public static string EnumToCode(CodeAmbulatoryStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAmountClass)"/>
        public static string EnumToCode(CodeAmountClass input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAmountType)"/>
        public static string EnumToCode(CodeAmountType input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeAssignmentOfBenefits)"/>
        public static string EnumToCode(CodeAssignmentOfBenefits input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBedStatus)"/>
        public static string EnumToCode(CodeBedStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeBodySite)"/>
        public static string EnumToCode(CodeBodySite input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCausalityObservations)"/>
        public static string EnumToCode(CodeCausalityObservations input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCertificationPatientType)"/>
        public static string EnumToCode(CodeCertificationPatientType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCertificationStatus)"/>
        public static string EnumToCode(CodeCertificationStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeChargeOnIndicator)"/>
        public static string EnumToCode(CodeChargeOnIndicator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeChargeType)"/>
        public static string EnumToCode(CodeChargeType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCheckDigitScheme)"/>
        public static string EnumToCode(CodeCheckDigitScheme input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCommentType)"/>
        public static string EnumToCode(CodeCommentType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeCompletionStatus)"/>
        public static string EnumToCode(CodeCompletionStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConditionCode)"/>
        public static string EnumToCode(CodeConditionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeConfidentialityCode)"/>
        public static string EnumToCode(CodeConfidentialityCode input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDateTimeSelectionQualifier)"/>
        public static string EnumToCode(CodeDateTimeSelectionQualifier input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDaysOfTheWeek)"/>
        public static string EnumToCode(CodeDaysOfTheWeek input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDayType)"/>
        public static string EnumToCode(CodeDayType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDeferredResponseType)"/>
        public static string EnumToCode(CodeDeferredResponseType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDegreeLicenseCertificate)"/>
        public static string EnumToCode(CodeDegreeLicenseCertificate input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDelayedAcknowledgmentType)"/>
        public static string EnumToCode(CodeDelayedAcknowledgmentType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDerivedSpecimen)"/>
        public static string EnumToCode(CodeDerivedSpecimen input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDrgPayor)"/>
        public static string EnumToCode(CodeDrgPayor input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeDurationCategories)"/>
        public static string EnumToCode(CodeDurationCategories input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEligibilitySource)"/>
        public static string EnumToCode(CodeEligibilitySource input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEncoding)"/>
        public static string EnumToCode(CodeEncoding input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEscortRequired)"/>
        public static string EnumToCode(CodeEscortRequired input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventReportedTo)"/>
        public static string EnumToCode(CodeEventReportedTo input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventSeriousness)"/>
        public static string EnumToCode(CodeEventSeriousness input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeEventTypeCode)"/>
        public static string EnumToCode(CodeEventTypeCode input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeIdentifierType)"/>
        public static string EnumToCode(CodeIdentifierType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeIdentityMayBeDivulged)"/>
        public static string EnumToCode(CodeIdentityMayBeDivulged input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeIndirectExposureMechanism)"/>
        public static string EnumToCode(CodeIndirectExposureMechanism input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInsuranceCompanyContactReason)"/>
        public static string EnumToCode(CodeInsuranceCompanyContactReason input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInterpretationCodes)"/>
        public static string EnumToCode(CodeInterpretationCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeInvocationEvent)"/>
        public static string EnumToCode(CodeInvocationEvent input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeKindOfQuantity)"/>
        public static string EnumToCode(CodeKindOfQuantity input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLocationCharacteristicId)"/>
        public static string EnumToCode(CodeLocationCharacteristicId input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLocationEquipment)"/>
        public static string EnumToCode(CodeLocationEquipment input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeLocationRelationshipId)"/>
        public static string EnumToCode(CodeLocationRelationshipId input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMailClaimParty)"/>
        public static string EnumToCode(CodeMailClaimParty input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeManufacturersOfVaccines)"/>
        public static string EnumToCode(CodeManufacturersOfVaccines input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMessageErrorConditionCodes)"/>
        public static string EnumToCode(CodeMessageErrorConditionCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMessageStructure)"/>
        public static string EnumToCode(CodeMessageStructure input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMessageType)"/>
        public static string EnumToCode(CodeMessageType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMfnRecordLevelErrorReturn)"/>
        public static string EnumToCode(CodeMfnRecordLevelErrorReturn input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMilitaryRankGrade)"/>
        public static string EnumToCode(CodeMilitaryRankGrade input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMilitaryService)"/>
        public static string EnumToCode(CodeMilitaryService input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMilitaryStatus)"/>
        public static string EnumToCode(CodeMilitaryStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMimeBase64EncodingCharacters)"/>
        public static string EnumToCode(CodeMimeBase64EncodingCharacters input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeModality)"/>
        public static string EnumToCode(CodeModality input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeMoneyOrPercentageIndicator)"/>
        public static string EnumToCode(CodeMoneyOrPercentageIndicator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeNameAddressRepresentation)"/>
        public static string EnumToCode(CodeNameAddressRepresentation input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOrganDonorCode)"/>
        public static string EnumToCode(CodeOrganDonorCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOrganizationalNameType)"/>
        public static string EnumToCode(CodeOrganizationalNameType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOutlierType)"/>
        public static string EnumToCode(CodeOutlierType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeOverride)"/>
        public static string EnumToCode(CodeOverride input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientClass)"/>
        public static string EnumToCode(CodePatientClass input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientLocationType)"/>
        public static string EnumToCode(CodePatientLocationType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientOutcome)"/>
        public static string EnumToCode(CodePatientOutcome input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePatientsRelationshiptoInsured)"/>
        public static string EnumToCode(CodePatientsRelationshiptoInsured input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePolicyType)"/>
        public static string EnumToCode(CodePolicyType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePractitionerIdNumberType)"/>
        public static string EnumToCode(CodePractitionerIdNumberType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodePreferredMethodOfContact)"/>
        public static string EnumToCode(CodePreferredMethodOfContact input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcedureFunctionalType)"/>
        public static string EnumToCode(CodeProcedureFunctionalType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProcedurePractitionerIdentifierCodeType)"/>
        public static string EnumToCode(CodeProcedurePractitionerIdentifierCodeType input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProductSource)"/>
        public static string EnumToCode(CodeProductSource input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProviderBilling)"/>
        public static string EnumToCode(CodeProviderBilling input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeProviderRole)"/>
        public static string EnumToCode(CodeProviderRole input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeQueryResponseFormatCode)"/>
        public static string EnumToCode(CodeQueryResponseFormatCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeQueryResponseStatus)"/>
        public static string EnumToCode(CodeQueryResponseStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeQueryResultsLevel)"/>
        public static string EnumToCode(CodeQueryResultsLevel input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReadmissionIndicator)"/>
        public static string EnumToCode(CodeReadmissionIndicator input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelatednessAssessment)"/>
        public static string EnumToCode(CodeRelatednessAssessment input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelationalConjunction)"/>
        public static string EnumToCode(CodeRelationalConjunction input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelationalOperator)"/>
        public static string EnumToCode(CodeRelationalOperator input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRelationshipModifier)"/>
        public static string EnumToCode(CodeRelationshipModifier input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReligion)"/>
        public static string EnumToCode(CodeReligion input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReportingPriority)"/>
        public static string EnumToCode(CodeReportingPriority input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeReportPriority)"/>
        public static string EnumToCode(CodeReportPriority input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeResultStatus)"/>
        public static string EnumToCode(CodeResultStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRoomType)"/>
        public static string EnumToCode(CodeRoomType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRouteOfAdministration)"/>
        public static string EnumToCode(CodeRouteOfAdministration input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeRXComponentType)"/>
        public static string EnumToCode(CodeRXComponentType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSegmentActionCode)"/>
        public static string EnumToCode(CodeSegmentActionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSourceOfComment)"/>
        public static string EnumToCode(CodeSourceOfComment input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSourceType)"/>
        public static string EnumToCode(CodeSourceType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecialtyType)"/>
        public static string EnumToCode(CodeSpecialtyType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenActionCode)"/>
        public static string EnumToCode(CodeSpecimenActionCode input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSpecimenSourceCodes)"/>
        public static string EnumToCode(CodeSpecimenSourceCodes input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeStatusOfEvaluation)"/>
        public static string EnumToCode(CodeStatusOfEvaluation input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeStudentStatus)"/>
        public static string EnumToCode(CodeStudentStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSubstitutionStatus)"/>
        public static string EnumToCode(CodeSubstitutionStatus input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeSubtypeOfReferencedData)"/>
        public static string EnumToCode(CodeSubtypeOfReferencedData input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTelecommunicationEquipmentType)"/>
        public static string EnumToCode(CodeTelecommunicationEquipmentType input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTransactionType)"/>
        public static string EnumToCode(CodeTransactionType input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTypeOfAgreement)"/>
        public static string EnumToCode(CodeTypeOfAgreement input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeTypeOfReferencedData)"/>
        public static string EnumToCode(CodeTypeOfReferencedData input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeUniversalIdType)"/>
        public static string EnumToCode(CodeUniversalIdType input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeVaccinesAdministered)"/>
        public static string EnumToCode(CodeVaccinesAdministered input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeValueCode)"/>
        public static string EnumToCode(CodeValueCode input)
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

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeWhatSubjectFilter)"/>
        public static string EnumToCode(CodeWhatSubjectFilter input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeWhichDateTimeQualifier)"/>
        public static string EnumToCode(CodeWhichDateTimeQualifier input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeWhichDateTimeStatusQualifier)"/>
        public static string EnumToCode(CodeWhichDateTimeStatusQualifier input)
            => _instance.EnumToCode(input);

        /// <inheritdoc cref="IEnumHelper.EnumToCode(CodeYesNoIndicator)"/>
        public static string EnumToCode(CodeYesNoIndicator input)
            => _instance.EnumToCode(input);
    }
}
