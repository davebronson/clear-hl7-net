namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0003 - Event Type Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0003</remarks>
    public enum CodeEventTypeCode
    {
        /// <summary>
        /// A01 - ADT/ACK - Admit/visit notification.
        /// </summary>
        AdtAckAdmitVisitNotification,

        /// <summary>
        /// A02 - ADT/ACK - Transfer a patient.
        /// </summary>
        AdtAckTransferAPatient,

        /// <summary>
        /// A03 - ADT/ACK -  Discharge/end visit.
        /// </summary>
        AdtAckDischargeEndVisit,

        /// <summary>
        /// A04 - ADT/ACK -  Register a patient.
        /// </summary>
        AdtAckRegisterAPatient,

        /// <summary>
        /// A05 - ADT/ACK -  Pre-admit a patient.
        /// </summary>
        AdtAckPreAdmitAPatient,

        /// <summary>
        /// A06 - ADT/ACK -  Change an outpatient to an inpatient.
        /// </summary>
        AdtAckChangeAnOutpatientToAnInpatient,

        /// <summary>
        /// A07 - ADT/ACK -  Change an inpatient to an outpatient.
        /// </summary>
        AdtAckChangeAnInpatientToAnOutpatient,

        /// <summary>
        /// A08 - ADT/ACK -  Update patient information.
        /// </summary>
        AdtAckUpdatePatientInformation,

        /// <summary>
        /// A09 - ADT/ACK -  Patient departing - tracking.
        /// </summary>
        AdtAckPatientDepartingTracking,

        /// <summary>
        /// A10 - ADT/ACK -  Patient arriving - tracking.
        /// </summary>
        AdtAckPatientArrivingTracking,

        /// <summary>
        /// A11 - ADT/ACK -  Cancel admit/visit notification.
        /// </summary>
        AdtAckCancelAdmitVisitNotification,

        /// <summary>
        /// A12 - ADT/ACK -  Cancel transfer.
        /// </summary>
        AdtAckCancelTransfer,

        /// <summary>
        /// A13 - ADT/ACK -  Cancel discharge/end visit.
        /// </summary>
        AdtAckCancelDischargeEndVisit,

        /// <summary>
        /// A14 - ADT/ACK -  Pending admit.
        /// </summary>
        AdtAckPendingAdmit,

        /// <summary>
        /// A15 - ADT/ACK -  Pending transfer.
        /// </summary>
        AdtAckPendingTransfer,

        /// <summary>
        /// A16 - ADT/ACK -  Pending discharge.
        /// </summary>
        AdtAckPendingDischarge,

        /// <summary>
        /// A17 - ADT/ACK -  Swap patients.
        /// </summary>
        AdtAckSwapPatients,

        /// <summary>
        /// A18 - ADT/ACK -  Merge patient information.
        /// </summary>
        AdtAckMergePatientInformation,

        /// <summary>
        /// A19 - QRY/ADR -  Patient query.
        /// </summary>
        QryAdrPatientQuery,

        /// <summary>
        /// A20 - ADT/ACK -  Bed status update.
        /// </summary>
        AdtAckBedStatusUpdate,

        /// <summary>
        /// A21 - ADT/ACK -  Patient goes on a "leave of absence".
        /// </summary>
        AdtAckPatientGoesOnALeaveOfAbsence,

        /// <summary>
        /// A22 - ADT/ACK -  Patient returns from a "leave of absence".
        /// </summary>
        AdtAckPatientReturnsFromALeaveOfAbsence,

        /// <summary>
        /// A23 - ADT/ACK -  Delete a patient record.
        /// </summary>
        AdtAckDeleteAPatientRecord,

        /// <summary>
        /// A24 - ADT/ACK -  Link patient information.
        /// </summary>
        AdtAckLinkPatientInformation,

        /// <summary>
        /// A25 - ADT/ACK -  Cancel pending discharge.
        /// </summary>
        AdtAckCancelPendingDischarge,

        /// <summary>
        /// A26 - ADT/ACK -  Cancel pending transfer.
        /// </summary>
        AdtAckCancelPendingTransfer,

        /// <summary>
        /// A27 - ADT/ACK -  Cancel pending admit.
        /// </summary>
        AdtAckCancelPendingAdmit,

        /// <summary>
        /// A28 - ADT/ACK -  Add person information.
        /// </summary>
        AdtAckAddPersonInformation,

        /// <summary>
        /// A29 - ADT/ACK -  Delete person information.
        /// </summary>
        AdtAckDeletePersonInformation,

        /// <summary>
        /// A30 - ADT/ACK -  Merge person information.
        /// </summary>
        AdtAckMergePersonInformation,

        /// <summary>
        /// A31 - ADT/ACK -  Update person information.
        /// </summary>
        AdtAckUpdatePersonInformation,

        /// <summary>
        /// A32 - ADT/ACK -  Cancel patient arriving - tracking.
        /// </summary>
        AdtAckCancelPatientArrivingTracking,

        /// <summary>
        /// A33 - ADT/ACK -  Cancel patient departing - tracking.
        /// </summary>
        AdtAckCancelPatientDepartingTracking,

        /// <summary>
        /// A34 - ADT/ACK -  Merge patient information - patient ID only.
        /// </summary>
        AdtAckMergePatientInfoPatientId,

        /// <summary>
        /// A35 - ADT/ACK -  Merge patient information - account number only.
        /// </summary>
        AdtAckMergePatientInfoAccountNumber,

        /// <summary>
        /// A36 - ADT/ACK -  Merge patient information - patient ID and account number.
        /// </summary>
        AdtAckMergePatientInfoPatientIdAccountNumber,

        /// <summary>
        /// A37 - ADT/ACK -  Unlink patient information.
        /// </summary>
        AdtAckUnlinkPatientInformation,

        /// <summary>
        /// A38 - ADT/ACK - Cancel pre-admit.
        /// </summary>
        AdtAckCancelPreAdmit,

        /// <summary>
        /// A39 - ADT/ACK - Merge person - patient ID.
        /// </summary>
        AdtAckMergePersonPatientId,

        /// <summary>
        /// A40 - ADT/ACK - Merge patient - patient identifier list.
        /// </summary>
        AdtAckMergePatientPatientIdList,

        /// <summary>
        /// A41 - ADT/ACK - Merge account - patient account number.
        /// </summary>
        AdtAckMergeAccountPatientAccountNumber,

        /// <summary>
        /// A42 - ADT/ACK - Merge visit - visit number.
        /// </summary>
        AdtAckMergeVisitVisitNumber,

        /// <summary>
        /// A43 - ADT/ACK - Move patient information - patient identifier list.
        /// </summary>
        AdtAckMovePatientInfoPatientIdList,

        /// <summary>
        /// A44 - ADT/ACK - Move account information - patient account number.
        /// </summary>
        AdtAckMoveAccountInfoPatientAccountNumber,

        /// <summary>
        /// A45 - ADT/ACK - Move visit information - visit number.
        /// </summary>
        AdtAckMoveVisitInfoVisitNumber,

        /// <summary>
        /// A46 - ADT/ACK - Change patient ID.
        /// </summary>
        AdtAckChangePatientId,

        /// <summary>
        /// A47 - ADT/ACK - Change patient identifier list.
        /// </summary>
        AdtAckChangePatientIdList,

        /// <summary>
        /// A48 - ADT/ACK - Change alternate patient ID.
        /// </summary>
        AdtAckChangeAlternatePatientId,

        /// <summary>
        /// A49 - ADT/ACK - Change patient account number.
        /// </summary>
        AdtAckChangePatientAccountNumber,

        /// <summary>
        /// A50 - ADT/ACK - Change visit number.
        /// </summary>
        AdtAckChangeVisitNumber,

        /// <summary>
        /// A51 - ADT/ACK - Change alternate visit ID.
        /// </summary>
        AdtAckChangeAlternateVisitId,

        /// <summary>
        /// C01 - CRM - Register a patient on a clinical trial.
        /// </summary>
        CrmRegisterPatientOnClinicalTrial,

        /// <summary>
        /// C02 - CRM - Cancel a patient registration on clinical trial (for clerical mistakes only).
        /// </summary>
        CrmCancelPatientRegistrationOnClinicalTrial,

        /// <summary>
        /// C03 - CRM - Correct/update registration information.
        /// </summary>
        CrmUpdateRegistrationInformation,

        /// <summary>
        /// C04 - CRM - Patient has gone off a clinical trial.
        /// </summary>
        CrmPatientOffClinicalTrial,

        /// <summary>
        /// C05 - CRM - Patient enters phase of clinical trial.
        /// </summary>
        CrmPatientEntersPhaseOfClinicalTrial,

        /// <summary>
        /// C06 - CRM - Cancel patient entering a phase (clerical mistake).
        /// </summary>
        CrmCancelPatientEnteringPhase,

        /// <summary>
        /// C07 - CRM - Correct/update phase information.
        /// </summary>
        CrmUpdatePhaseInfo,

        /// <summary>
        /// C08 - CRM - Patient has gone off phase of clinical trial.
        /// </summary>
        CrmPatientHasGoneOffPhaseOfClinicalTrial,

        /// <summary>
        /// C09 - CSU - Automated time intervals for reporting, like monthly.
        /// </summary>
        CsuAutomatedTimeIntervalsForReporting,

        /// <summary>
        /// C10 - CSU - Patient completes the clinical trial.
        /// </summary>
        CsuPatientCompletesClinicalTrial,

        /// <summary>
        /// C11 - CSU - Patient completes a phase of the clinical trial.
        /// </summary>
        CsuPatientCompletesPhaseOfClinicalTrial,

        /// <summary>
        /// C12 - CSU - Update/correction of patient order/result information.
        /// </summary>
        CsuUpdatePatientOrderResultInfo,

        /// <summary>
        /// CNQ - Cancel Query.
        /// </summary>
        CancelQuery,

        /// <summary>
        /// I01 - RQI/RPI - Request for insurance information.
        /// </summary>
        RqiRpiRequestForInsuranceInformation,

        /// <summary>
        /// I02 - RQI/RPL - Request/receipt of patient selection display list.
        /// </summary>
        RqiRplRequestReceiptOfPatientSelectionDisplayList,

        /// <summary>
        /// I03 - RQI/RPR - Request/receipt of patient selection list.
        /// </summary>
        RqiRprRequestReceiptOfPatientSelectionList,

        /// <summary>
        /// I04 - RQD/RPI - Request for patient demographic data.
        /// </summary>
        RqdRpiRequestForPatientDemographicData,

        /// <summary>
        /// I05 - RQC/RCI - Request for patient clinical information.
        /// </summary>
        RqcRciRequestForPatientClinicalInformation,

        /// <summary>
        /// I06 - RQC/RCL - Request/receipt of clinical data listing.
        /// </summary>
        RqcRclRequestReceiptOfClinicalDataListing,

        /// <summary>
        /// I07 - PIN/ACK - Unsolicited insurance information.
        /// </summary>
        PinAckUnsolicitedInsuranceInformation,

        /// <summary>
        /// I08 - RQA/RPA - Request for treatment authorization information.
        /// </summary>
        RqaRpaRequestForTreatmentAuthorizationInformation,

        /// <summary>
        /// I09 - RQA/RPA - Request for modification to an authorization.
        /// </summary>
        RqaRpaRequestForModificationToAuthorization,

        /// <summary>
        /// I10 - RQA/RPA - Request for resubmission of an authorization.
        /// </summary>
        RqaRpaRequestForResubmissionOfAuthorization,

        /// <summary>
        /// I11 - RQA/RPA - Request for cancellation of an authorization.
        /// </summary>
        RqaRpaRequestForCancellationOfAuthorization,

        /// <summary>
        /// I12 - REF/RRI - Patient referral.
        /// </summary>
        RefRriPatientReferral,

        /// <summary>
        /// I13 - REF/RRI - Modify patient referral.
        /// </summary>
        RefRriModifyPatientReferral,

        /// <summary>
        /// I14 - REF/RRI - Cancel patient referral.
        /// </summary>
        RefRriCancelPatientReferral,

        /// <summary>
        /// I15 - REF/RRI - Request patient referral status.
        /// </summary>
        RefRriRequestPatientReferralStatus,

        /// <summary>
        /// M01 - MFN/MFK - Master file not otherwise specified.
        /// </summary>
        MfnMfkMasterFileNotOtherwiseSpecified,

        /// <summary>
        /// M02 - MFN/MFK - Master file - staff practitioner.
        /// </summary>
        MfnMfkMasterFileStaffPractitioner,

        /// <summary>
        /// M03 - MFN/MFK - Master file - test/observation.
        /// </summary>
        MfnMfkMasterFileTestObservation,

        /// <summary>
        /// M04 - MFN/MFK - Master files charge description.
        /// </summary>
        MfnMfkMasterFilesChargeDescription,

        /// <summary>
        /// M05 - MFN/MFK - Patient location master file.
        /// </summary>
        MfnMfkPatientLocationMasterFile,

        /// <summary>
        /// M06 - MFN/MFK - Clinical study with phases and schedules master file.
        /// </summary>
        MfnMfkClinicalStudyWithPhasesAndSchedulesMasterFile,

        /// <summary>
        /// M07 - MFN/MFK - Clinical study without phases but with schedules master file.
        /// </summary>
        MfnMfkClinicalStudyWithoutPhasesButWithSchedulesMasterFile,

        /// <summary>
        /// M08 - MFN/MFK - Test/observation (numeric) master file.
        /// </summary>
        MfnMfkTestObservationNumericMasterFile,

        /// <summary>
        /// M09 - MFN/MFK - Test/observation (categorical) master file.
        /// </summary>
        MfnMfkTestObservationCategoricalMasterFile,

        /// <summary>
        /// M10 - MFN/MFK - Test /observation batteries master file.
        /// </summary>
        MfnMfkTestObservationBatteriesMasterFile,

        /// <summary>
        /// M11 - MFN/MFK - Test/calculated observations master file.
        /// </summary>
        MfnMfkTestCalculatedObservationsMasterFile,

        /// <summary>
        /// O01 - ORM - Order message (also RDE, RDS, RGV, RAS).
        /// </summary>
        OrmOrderMessage,

        /// <summary>
        /// O02 - ORR - Order response (also RRE, RRD, RRG, RRA).
        /// </summary>
        OrrOrderResponse,

        /// <summary>
        /// P01 - BAR/ACK - Add patient accounts.
        /// </summary>
        BarAckAddPatientAccounts,

        /// <summary>
        /// P02 - BAR/ACK - Purge patient accounts.
        /// </summary>
        BarAckPurgePatientAccounts,

        /// <summary>
        /// P03 - DFT/ACK - Post detail financial transaction.
        /// </summary>
        DftAckPostDetailFinancialTransaction,

        /// <summary>
        /// P04 - QRY/DSP - Generate bill and A/R statements.
        /// </summary>
        QryDspGenerateBillAndARStatements,

        /// <summary>
        /// P05 - BAR/ACK - Update account.
        /// </summary>
        BarAckUpdateAccount,

        /// <summary>
        /// P06 - BAR/ACK - End account.
        /// </summary>
        BarAckEndAccount,

        /// <summary>
        /// P07 - PEX - Unsolicited initial individual product experience report.
        /// </summary>
        PexUnsolicitedInitialExperienceReport,

        /// <summary>
        /// P08 - PEX - Unsolicited update individual product experience report.
        /// </summary>
        PexUnsolicitedUpdateExperienceReport,

        /// <summary>
        /// P09 - SUR - Summary product experience report.
        /// </summary>
        SurSummaryExperienceReport,

        /// <summary>
        /// PC1 - PPR - PC/ problem add.
        /// </summary>
        PprPcProblemAdd,

        /// <summary>
        /// PC2 - PPR - PC/ problem update.
        /// </summary>
        PprPcProblemUpdate,

        /// <summary>
        /// PC3 - PPR - PC/ problem delete.
        /// </summary>
        PprPcProblemDelete,

        /// <summary>
        /// PC4 - QRY - PC/ problem query.
        /// </summary>
        QryPcProblemQuery,

        /// <summary>
        /// PC5 - PRR - PC/ problem response.
        /// </summary>
        PrrPcProblemResponse,

        /// <summary>
        /// PC6 - PGL - PC/ goal add.
        /// </summary>
        PglPcGoalAdd,

        /// <summary>
        /// PC7 - PGL - PC/ goal update.
        /// </summary>
        PglPcGoalUpdate,

        /// <summary>
        /// PC8 - PGL - PC/ goal delete.
        /// </summary>
        PglPcGoalDelete,

        /// <summary>
        /// PC9 - QRY - PC/ goal query.
        /// </summary>
        QryPcGoalQuery,

        /// <summary>
        /// PCA - PPV - PC/ goal response.
        /// </summary>
        PpvPcGoalResponse,

        /// <summary>
        /// PCB - PPP - PC/ pathway (problem-oriented) add.
        /// </summary>
        PppPcPathwayProblemOrientedAdd,

        /// <summary>
        /// PCC - PPP - PC/ pathway (problem-oriented) update.
        /// </summary>
        PppPcPathwayProblemOrientedUpdate,

        /// <summary>
        /// PCD - PPP - PC/ pathway (problem-oriented) delete.
        /// </summary>
        PppPcPathwayProblemOrientedDelete,

        /// <summary>
        /// PCE - QRY - PC/ pathway (problem-oriented) query.
        /// </summary>
        QryPcPathwayProblemOrientedQuery,

        /// <summary>
        /// PCF - PTR - PC/ pathway (problem-oriented) query response.
        /// </summary>
        PtrPcPathwayProblemOrientedQueryResponse,

        /// <summary>
        /// PCG - PPG - PC/ pathway (goal-oriented) add.
        /// </summary>
        PpgPcPathwayGoalOrientedAdd,

        /// <summary>
        /// PCH - PPG - PC/ pathway (goal-oriented) update.
        /// </summary>
        PpgPcPathwayGoalOrientedUpdate,

        /// <summary>
        /// PCJ - PPG - PC/ pathway (goal-oriented) delete.
        /// </summary>
        PpgPcPathwayGoalOrientedDelete,

        /// <summary>
        /// PCK - QRY - PC/ pathway (goal-oriented) query.
        /// </summary>
        QryPcPathwayGoalOrientedQuery,

        /// <summary>
        /// PCL - PPT - PC/ pathway (goal-oriented) query response.
        /// </summary>
        PptPcPathwayGoalOrientedQueryResponse,

        /// <summary>
        /// Q01 - QRY/DSR - Query sent for immediate response.
        /// </summary>
        QryDsrQuerySentForImmediateResponse,

        /// <summary>
        /// Q02 - QRY/QCK - Query sent for deferred response.
        /// </summary>
        QryQckQuerySentForDeferredResponse,

        /// <summary>
        /// Q03 - DSR/ACK - Deferred response to a query.
        /// </summary>
        DsrAckDeferredResponseToAQuery,

        /// <summary>
        /// Q05 - UDM/ACK - Unsolicited display update message.
        /// </summary>
        UdmAckUnsolicitedDisplayUpdateMessage,

        /// <summary>
        /// Q06 - OSQ/OSR - Query for order status.
        /// </summary>
        OsqOsrQueryForOrderStatus,

        /// <summary>
        /// R01 - ORU/ACK - Unsolicited transmission of an observation message.
        /// </summary>
        OruAckUnsolicitedTransmissionOfObservation,

        /// <summary>
        /// R02 - QRY - Query for results of observation.
        /// </summary>
        QryQueryForResultsOfObservation,

        /// <summary>
        /// R03 - QRY/DSR Display-oriented results, query/unsol. update (for backward compatibility only) (Replaced by Q05).
        /// </summary>
        QryDsrDisplayOrientedResultsQueryUnsolUpdate,

        /// <summary>
        /// R04 - ORF - Response to query; transmission of requested observation.
        /// </summary>
        OrfResponseToQueryTransmissionOfRequestedObservation,

        /// <summary>
        /// R05 - QRY/DSR - query for display results (See Q01).
        /// </summary>
        QryDsrQueryForDisplayResults,

        /// <summary>
        /// R06 - UDM - unsolicited update/display results (See Q05).
        /// </summary>
        UdmUnsolicitedUpdateDisplayResults,

        /// <summary>
        /// RAR - RAR - Pharmacy administration information query response.
        /// </summary>
        RarPharmacyAdministrationInfoQueryResponse,

        /// <summary>
        /// RDR - RDR - Pharmacy dispense information query response.
        /// </summary>
        RdrPharmacyDispenseInfoQueryResponse,

        /// <summary>
        /// RER - RER - Pharmacy encoded order information query response.
        /// </summary>
        RerPharmacyEncodedOrderInfoQueryResponse,

        /// <summary>
        /// RGR - RGR - Pharmacy dose information query response.
        /// </summary>
        RgrPharmacyDoseInfoQueryResponse,

        /// <summary>
        /// ROR - ROR - Pharmacy prescription order query response.
        /// </summary>
        RorPharmacyPrescriptionOrderQueryResponse,

        /// <summary>
        /// S01 - SRM/SRR - Request new appointment booking.
        /// </summary>
        SrmSrrRequestNewAppointmentBooking,

        /// <summary>
        /// S02 - SRM/SRR - Request appointment rescheduling.
        /// </summary>
        SrmSrrRequestAppointmentRescheduling,

        /// <summary>
        /// S03 - SRM/SRR - Request appointment modification.
        /// </summary>
        SrmSrrRequestAppointmentModification,

        /// <summary>
        /// S04 - SRM/SRR - Request appointment cancellation.
        /// </summary>
        SrmSrrRequestAppointmentCancellation,

        /// <summary>
        /// S05 - SRM/SRR - Request appointment discontinuation.
        /// </summary>
        SrmSrrRequestAppointmentDiscontinuation,

        /// <summary>
        /// S06 - SRM/SRR - Request appointment deletion.
        /// </summary>
        SrmSrrRequestAppointmentDeletion,

        /// <summary>
        /// S07 - SRM/SRR - Request addition of service/resource on appointment.
        /// </summary>
        SrmSrrRequestAdditionOfServiceOnAppointment,

        /// <summary>
        /// S08 - SRM/SRR - Request modification of service/resource on appointment.
        /// </summary>
        SrmSrrRequestModificationOfServiceOnAppointment,

        /// <summary>
        /// S09 - SRM/SRR - Request cancellation of service/resource on appointment.
        /// </summary>
        SrmSrrRequestCancellationOfServiceOnAppointment,

        /// <summary>
        /// S10 - SRM/SRR - Request discontinuation of service/resource on appointment.
        /// </summary>
        SrmSrrRequestDiscontinuationOfServiceOnAppointment,

        /// <summary>
        /// S11 - SRM/SRR - Request deletion of service/resource on appointment.
        /// </summary>
        SrmSrrRequestDeletionOfServiceOnAppointment,

        /// <summary>
        /// S12 - SIU/ACK - Notification of new appointment booking.
        /// </summary>
        SiuAckNotifyNewAppointmentBooking,

        /// <summary>
        /// S13 - SIU/ACK - Notification of appointment rescheduling.
        /// </summary>
        SiuAckNotifyAppointmentRescheduling,

        /// <summary>
        /// S14 - SIU/ACK - Notification of appointment modification.
        /// </summary>
        SiuAckNotifyAppointmentModification,

        /// <summary>
        /// S15 - SIU/ACK - Notification of appointment cancellation.
        /// </summary>
        SiuAckNotifyAppointmentCancellation,

        /// <summary>
        /// S16 - SIU/ACK - Notification of appointment discontinuation.
        /// </summary>
        SiuAckNotificationOfAppointmentDiscontinuation,

        /// <summary>
        /// S17 - SIU/ACK - Notification of appointment deletion.
        /// </summary>
        SiuAckNotifyAppointmentDeletion,

        /// <summary>
        /// S18 - SIU/ACK - Notification of addition of service/resource on appointment.
        /// </summary>
        SiuAckNotifyAdditionOfServiceOnAppointment,

        /// <summary>
        /// S19 - SIU/ACK - Notification of modification of service/resource on appointment.
        /// </summary>
        SiuAckNotifyModificationOfServiceOnAppointment,

        /// <summary>
        /// S20 - SIU/ACK - Notification of cancellation of service/resource on appointment.
        /// </summary>
        SiuAckNotifyCancellationOfServiceOnAppointment,

        /// <summary>
        /// S21 - SIU/ACK - Notification of discontinuation of service/resource on appointment.
        /// </summary>
        SiuAckNotifyDiscontinuationOfServiceOnAppointment,

        /// <summary>
        /// S22 - SIU/ACK - Notification of deletion of service/resource on appointment.
        /// </summary>
        SiuAckNotifyDeletionOfServiceResourceOnAppointment,

        /// <summary>
        /// S23 - SIU/ACK - Notification of blocked schedule time slot(s).
        /// </summary>
        SiuAckNotifyBlockedScheduleTimeSlots,

        /// <summary>
        /// S24 - SIU/ACK - Notification of opened ("unblocked") schedule time slot(s).
        /// </summary>
        SiuAckNotifyOpenedUnblockedScheduleTimeSlots,

        /// <summary>
        /// S25 - SQM/SQR - Schedule query message and response.
        /// </summary>
        SqmSqrScheduleQueryMessageAndResponse,

        /// <summary>
        /// S26 - SIU/ACK Notification that patient did not show up for schedule appointment.
        /// </summary>
        SiuAckNotifyPatientDidNotShowUpForAppointment,

        /// <summary>
        /// T01 - MDM/ACK - Original document notification.
        /// </summary>
        MdmAckOriginalDocument,

        /// <summary>
        /// T02 - MDM/ACK - Original document notification and content.
        /// </summary>
        MdmAckOriginalDocumentNotifyAndContent,

        /// <summary>
        /// T03 - MDM/ACK - Document status change notification.
        /// </summary>
        MdmAckDocumentStatusChange,

        /// <summary>
        /// T04 - MDM/ACK - Document status change notification and content.
        /// </summary>
        MdmAckDocumentStatusChangeNotifyAndContent,

        /// <summary>
        /// T05 - MDM/ACK - Document addendum notification.
        /// </summary>
        MdmAckDocumentAddendum,

        /// <summary>
        /// T06 - MDM/ACK - Document addendum notification and content.
        /// </summary>
        MdmAckDocumentAddendumNotifyAndContent,

        /// <summary>
        /// T07 - MDM/ACK - Document edit notification.
        /// </summary>
        MdmAckDocumentEdit,

        /// <summary>
        /// T08 - MDM/ACK - Document edit notification and content.
        /// </summary>
        MdmAckDocumentEditNotifyAndContent,

        /// <summary>
        /// T09 - MDM/ACK - Document replacement notification.
        /// </summary>
        MdmAckDocumentReplacement,

        /// <summary>
        /// T10 - MDM/ACK - Document replacement notification and content.
        /// </summary>
        MdmAckDocumentReplacementNotifyAndContent,

        /// <summary>
        /// T11 - MDM/ACK - Document cancel notification.
        /// </summary>
        MdmAckDocumentCancel,

        /// <summary>
        /// T12 - QRY/DOC - Document query.
        /// </summary>
        QryDocDocumentQuery,

        /// <summary>
        /// V01 - VXQ - Query for vaccination record.
        /// </summary>
        VxqQueryForVaccinationRecord,

        /// <summary>
        /// V02 - VXX - Response to vaccination query returning multiple PID matches.
        /// </summary>
        VxxResponseToVaccinationQueryMultiplePidMatches,

        /// <summary>
        /// V03 - VXR - Vaccination record response.
        /// </summary>
        VxrVaccinationRecordResponse,

        /// <summary>
        /// V04 - VXU - Unsolicited vaccination record update.
        /// </summary>
        VxuUnsolicitedVaccinationRecordUpdate,

        /// <summary>
        /// Varies - MFQ/MFR - Master files query (use event same as asking for e.g., M05 - location).
        /// </summary>
        MfqMfrMasterFilesQuery,

        /// <summary>
        /// W01 - ORU - Waveform result, unsolicited transmission of requested information.
        /// </summary>
        OruWaveformResultUnsolicitedTransmission,

        /// <summary>
        /// W02 - QRF - Waveform result, response to query.
        /// </summary>
        QrfWaveformResultResponseToQuery,

        /// <summary>
        /// X01 - PEX - Product experience.
        /// </summary>
        PexProductExperience
    }
}
