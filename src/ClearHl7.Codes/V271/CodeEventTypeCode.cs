namespace ClearHl7.Codes.V271
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
        /// A52 - ADT/ACK - Cancel leave of absence for a patient.
        /// </summary>
        AdtAckCancelLeaveOfAbsenceForAPatient,

        /// <summary>
        /// A53 - ADT/ACK - Cancel patient returns from a leave of absence.
        /// </summary>
        AdtAckCancelPatientReturnsFromLoa,

        /// <summary>
        /// A54 - ADT/ACK - Change attending doctor.
        /// </summary>
        AdtAckChangeAttendingDoctor,

        /// <summary>
        /// A55 - ADT/ACK - Cancel change attending doctor.
        /// </summary>
        AdtAckCancelChangeAttendingDoctor,

        /// <summary>
        /// A60 - ADT/ACK - Update allergy information.
        /// </summary>
        AdtAckUpdateAllergyInfo,

        /// <summary>
        /// A61 - ADT/ACK - Change consulting doctor.
        /// </summary>
        AdtAckChangeConsultingDoctor,

        /// <summary>
        /// A62 - ADT/ACK - Cancel change consulting doctor.
        /// </summary>
        AdtAckCancelChangeConsultingDoctor,

        /// <summary>
        /// B01 - PMU/ACK - Add personnel record.
        /// </summary>
        PmuAckAddPersonnelRecord,

        /// <summary>
        /// B02 - PMU/ACK - Update personnel record.
        /// </summary>
        PmuAckUpdatePersonnelRecord,

        /// <summary>
        /// B03 - PMU/ACK - Delete personnel re cord.
        /// </summary>
        PmuAckDeletePersonnelReCord,

        /// <summary>
        /// B04 - PMU/ACK - Active practicing person.
        /// </summary>
        PmuAckActivePracticingPerson,

        /// <summary>
        /// B05 - PMU/ACK - Deactivate practicing person.
        /// </summary>
        PmuAckDeactivatePracticingPerson,

        /// <summary>
        /// B06 - PMU/ACK - Terminate practicing person.
        /// </summary>
        PmuAckTerminatePracticingPerson,

        /// <summary>
        /// B07 - PMU/ACK - Grant Certificate/Permission.
        /// </summary>
        PmuAckGrantCertificatePermission,

        /// <summary>
        /// B08 - PMU/ACK - Revoke Certificate/Permission.
        /// </summary>
        PmuAckRevokeCertificatePermission,

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
        /// E01 - Submit HealthCare Services Invoice.
        /// </summary>
        SubmitHealthcareServicesInvoice,

        /// <summary>
        /// E02 - Cancel HealthCare Services Invoice.
        /// </summary>
        CancelHealthcareServicesInvoice,

        /// <summary>
        /// E03 - HealthCare Services Invoice Status.
        /// </summary>
        HealthcareServicesInvoiceStatus,

        /// <summary>
        /// E04 - Re-Assess HealthCare Services Invoice Request.
        /// </summary>
        ReassessHealthcareServicesInvoiceRequest,

        /// <summary>
        /// E10 - Edit/Adjudication Results.
        /// </summary>
        EditAdjudicationResults,

        /// <summary>
        /// E12 - Request Additional Information.
        /// </summary>
        RequestAdditionalInformation,

        /// <summary>
        /// E13 - Additional Information Response.
        /// </summary>
        AdditionalInformationResponse,

        /// <summary>
        /// E15 - Payment/Remittance Advice.
        /// </summary>
        PaymentRemittanceAdvice,

        /// <summary>
        /// E20 - Submit Authorization Request.
        /// </summary>
        SubmitAuthorizationRequest,

        /// <summary>
        /// E21 - Cancel Authorization Request.
        /// </summary>
        CancelAuthorizationRequest,

        /// <summary>
        /// E22 - Authorization Request Status.
        /// </summary>
        AuthorizationRequestStatus,

        /// <summary>
        /// E24 - Authorization Response.
        /// </summary>
        AuthorizationResponse,

        /// <summary>
        /// E30 - Submit Health Document related to Authorization Request.
        /// </summary>
        SubmitHealthDocumentRelatedToAuthorizationRequest,

        /// <summary>
        /// E31 - Cancel Health Document related to Authorization Request.
        /// </summary>
        CancelHealthDocumentRelatedToAuthorizationRequest,

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
        /// I16 - Collaborative Care Referral.
        /// </summary>
        CollaborativeCareReferral,

        /// <summary>
        /// I17 - Modify Collaborative Care Referral.
        /// </summary>
        ModifyCollaborativeCareReferral,

        /// <summary>
        /// I18 - Cancel Collaborative Care Referral.
        /// </summary>
        CancelCollaborativeCareReferral,

        /// <summary>
        /// I19 - Collaborative Care Query/Collaborative Care Query Update.
        /// </summary>
        CollaborativeCareQuery,

        /// <summary>
        /// I20 - Asynchronous Collaborative Care Update.
        /// </summary>
        AsynchronousCollaborativeCareUpdate,

        /// <summary>
        /// I21 - Collaborative Care Message.
        /// </summary>
        CollaborativeCareMessage,

        /// <summary>
        /// I22 - Collaborative Care Fetch / Collaborative Care Information.
        /// </summary>
        CollaborativeCareFetch,

        /// <summary>
        /// J01 - QCN/ACK - Cancel query/acknowledge message.
        /// </summary>
        QcnAckCancelQueryAcknowledgeMessage,

        /// <summary>
        /// J02 - QSX/ACK - Cancel subscription/acknowledge message.
        /// </summary>
        QsxAckCancelSubscriptionAcknowledgeMessage,

        /// <summary>
        /// K11 - RSP - Segment pattern response in response to QBP^Q11.
        /// </summary>
        RspSegmentPatternResponseInResponseToQbpQ11,

        /// <summary>
        /// K13 - RTB - Tabular response in response to QBP^Q13.
        /// </summary>
        RtbTabularResponseInResponseToQbpQ13,

        /// <summary>
        /// K15 - RDY - Display response in response to QBP^Q15.
        /// </summary>
        RdyDisplayResponseInResponseToQbpQ15,

        /// <summary>
        /// K21 - RSP - Get person demographics response.
        /// </summary>
        RspGetPersonDemographicsResponse,

        /// <summary>
        /// K22 - RSP - Find candidates response.
        /// </summary>
        RspFindCandidatesResponse,

        /// <summary>
        /// K23 - RSP - Get corresponding identifiers response.
        /// </summary>
        RspGetCorrespondingIdentifiersResponse,

        /// <summary>
        /// K24 - RSP - Allocate identifiers response.
        /// </summary>
        RspAllocateIdentifiersResponse,

        /// <summary>
        /// K25 - RSP - Personnel Information by Segment Response.
        /// </summary>
        RspPersonnelInformationBySegmentResponse,

        /// <summary>
        /// K31 - RSP -Dispense History Response.
        /// </summary>
        RspDispenseHistoryResponse,

        /// <summary>
        /// K32 - Find Candidates including Visit Information Response.
        /// </summary>
        FindCandidatesIncludingVisitInformationResponse,

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
        /// M12 - MFN/MFK - Master file notification message.
        /// </summary>
        MfnMfkMasterFileNotificationMessage,

        /// <summary>
        /// M13 - MFN/MFK - Master file notification - general.
        /// </summary>
        MfnMfkMasterFileNotificationGeneral,

        /// <summary>
        /// M14 - MFN/MFK - Master file notification - site defined.
        /// </summary>
        MfnMfkMasterFileNotificationSiteDefined,

        /// <summary>
        /// M15 - MFN/MFK - Inventory item master file notification.
        /// </summary>
        MfnMfkInventoryItemMasterFileNotification,

        /// <summary>
        /// M16 - MFN/MFK - Master File Notification Inventory Item Enhanced.
        /// </summary>
        MfnMfkMasterFileNotificationInventoryItemEnhanced,

        /// <summary>
        /// M17 - DRG Master File Message.
        /// </summary>
        DrgMasterFileMessage,

        /// <summary>
        /// N01 - NMQ/NMR - Application management query message.
        /// </summary>
        NmqNmrApplicationManagementQueryMessage,

        /// <summary>
        /// N02 - NMD/ACK - Application management data message (unsolicited).
        /// </summary>
        NmdAckApplicationManagementDataMessageUnsolicited,

        /// <summary>
        /// O01 - ORM - Order message (also RDE, RDS, RGV, RAS).
        /// </summary>
        OrmOrderMessage,

        /// <summary>
        /// O02 - ORR - Order response (also RRE, RRD, RRG, RRA).
        /// </summary>
        OrrOrderResponse,

        /// <summary>
        /// O03 - OMD - Diet order.
        /// </summary>
        OmdDietOrder,

        /// <summary>
        /// O04 - ORD - Diet order acknowledgment.
        /// </summary>
        OrdDietOrderAcknowledgment,

        /// <summary>
        /// O05 - OMS - Stock requisition order.
        /// </summary>
        OmsStockRequisitionOrder,

        /// <summary>
        /// O06 - ORS - Stock requisition acknowledgment.
        /// </summary>
        OrsStockRequisitionAcknowledgment,

        /// <summary>
        /// O07 - OMN - Non-stock requisition order.
        /// </summary>
        OmnNonStockRequisitionOrder,

        /// <summary>
        /// O08 - ORN - Non-stock requisition acknowledgment.
        /// </summary>
        OrnNonStockRequisitionAcknowledgment,

        /// <summary>
        /// O09 - OMP - Pharmacy/treatment order.
        /// </summary>
        OmpPharmacyTreatmentOrder,

        /// <summary>
        /// O10 - ORP - Pharmacy/treatment order acknowledgment.
        /// </summary>
        OrpPharmacyTreatmentOrderAcknowledgment,

        /// <summary>
        /// O11 - RDE - Pharmacy/treatment encoded order.
        /// </summary>
        RdePharmacyTreatmentEncodedOrder,

        /// <summary>
        /// O12 - RRE - Pharmacy/treatment encoded order acknowledgment.
        /// </summary>
        RrePharmacyTreatmentEncodedOrderAcknowledgment,

        /// <summary>
        /// O13 - RDS - Pharmacy/treatment dispense.
        /// </summary>
        RdsPharmacyTreatmentDispense,

        /// <summary>
        /// O14 - RRD - Pharmacy/treatment dispense acknowledgment.
        /// </summary>
        RrdPharmacyTreatmentDispenseAcknowledgment,

        /// <summary>
        /// O15 - RGV - Pharmacy/treatment give.
        /// </summary>
        RgvPharmacyTreatmentGive,

        /// <summary>
        /// O16 - RRG - Pharmacy/treatment give acknowledgment.
        /// </summary>
        RrgPharmacyTreatmentGiveAcknowledgment,

        /// <summary>
        /// O17 - RAS - Pharmacy/treatment administration.
        /// </summary>
        RasPharmacyTreatmentAdministration,

        /// <summary>
        /// O18 - RRA - Pharmacy/treatment administration acknowledgment.
        /// </summary>
        RraPharmacyTreatmentAdministrationAcknowledgment,

        /// <summary>
        /// O19 - OMG - General clinical order.
        /// </summary>
        OmgGeneralClinicalOrder,

        /// <summary>
        /// O20 - ORG/ORL - General clinical order response.
        /// </summary>
        OrgOrlGeneralClinicalOrderResponse,

        /// <summary>
        /// O21 - OML - Laboratory order.
        /// </summary>
        OmlLaboratoryOrder,

        /// <summary>
        /// O22 - ORL - General laboratory order response message to any OML.
        /// </summary>
        OrlGeneralLaboratoryOrderResponseMessageToAnyOml,

        /// <summary>
        /// O23 - OMI - Imaging order.
        /// </summary>
        OmiImagingOrder,

        /// <summary>
        /// O24 - ORI - Imaging order response message to any OMI.
        /// </summary>
        OriImagingOrderResponseMessageToAnyOmi,

        /// <summary>
        /// O25 - RDE - Pharmacy/treatment refill authorization request.
        /// </summary>
        RdePharmacyTreatmentRefillAuthorizationRequest,

        /// <summary>
        /// O26 - RRE - Pharmacy/Treatment Refill Authorization Acknowledgement.
        /// </summary>
        RrePharmacyTreatmentRefillAuthorizationAcknowledgement,

        /// <summary>
        /// O27 - OMB - Blood product order.
        /// </summary>
        OmbBloodProductOrder,

        /// <summary>
        /// O28 - ORB - Blood product order acknowledgment.
        /// </summary>
        OrbBloodProductOrderAcknowledgment,

        /// <summary>
        /// O29 - BPS - Blood product dispense status.
        /// </summary>
        BpsBloodProductDispenseStatus,

        /// <summary>
        /// O30 - BRP - Blood product dispense status acknowledgment.
        /// </summary>
        BrpBloodProductDispenseStatusAcknowledgment,

        /// <summary>
        /// O31 - BTS - Blood product transfusion/disposition.
        /// </summary>
        BtsBloodProductTransfusionDisposition,

        /// <summary>
        /// O32 - BRT - Blood product transfusion/disposition acknowledgment.
        /// </summary>
        BrtBloodProductTransfusionDispositionAcknowledgment,

        /// <summary>
        /// O33 - OML - Laboratory order for multiple orders related to a single specimen.
        /// </summary>
        OmlLabOrderForMultipleOrdersRelatedToASingleSpecimen,

        /// <summary>
        /// O34 - ORL - Laboratory order response message to a multiple order related to single specimen OML.
        /// </summary>
        OrlLabOrderResponseToMultipleOrderRelatedToSingleSpecimenOml,

        /// <summary>
        /// O35 - OML - Laboratory order for multiple orders related to a single container of a specimen.
        /// </summary>
        OmlLabOrderForMultipleOrdersRelatedToSingleSpecimen,

        /// <summary>
        /// O36 - ORL - Laboratory order response message to a single container of a specimen OML.
        /// </summary>
        OrlLabOrderResponseToSingleSpecimenOml,

        /// <summary>
        /// O37 - OPL - Population/Location-Based Laboratory Order Message.
        /// </summary>
        OplPopulationLocationBasedLabOrder,

        /// <summary>
        /// O38 - OPR - Population/Location-Based Laboratory Order Acknowledgment Message.
        /// </summary>
        OprPopulationLocationBasedLabOrderAcknowledgment,

        /// <summary>
        /// O39 - Specimen shipment centric laboratory order.
        /// </summary>
        SpecimenShipmentCentricLabOrder,

        /// <summary>
        /// O40 - Specimen Shipment Centric Laboratory Order Acknowledgment Message.
        /// </summary>
        SpecimenShipmentCentricLabOrderAcknowledgment,

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
        /// P10 - BAR/ACK -Transmit Ambulatory Payment  Classification(APC).
        /// </summary>
        BarAckTransmitAmbulatoryPaymentClassificationApc,

        /// <summary>
        /// P11 - DFT/ACK - Post Detail Financial Transactions - New.
        /// </summary>
        DftAckPostDetailFinancialTransactionsNew,

        /// <summary>
        /// P12 - BAR/ACK - Update Diagnosis/Procedure.
        /// </summary>
        BarAckUpdateDiagnosisProcedure,

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
        /// Q11 - QBP - Query by parameter requesting an RSP segment pattern response.
        /// </summary>
        QbpQueryByParameterRequestingRspSegmentPatternResponse,

        /// <summary>
        /// Q13 - QBP - Query by parameter requesting an  RTB - tabular response.
        /// </summary>
        QbpQueryByParameterRequestingRtbTabularResponse,

        /// <summary>
        /// Q15 - QBP - Query by parameter requesting an RDY display response.
        /// </summary>
        QbpQueryByParameterRequestingRdyDisplayResponse,

        /// <summary>
        /// Q16 - QSB - Create subscription.
        /// </summary>
        QsbCreateSubscription,

        /// <summary>
        /// Q17 - QVR - Query for previous events.
        /// </summary>
        QvrQueryForPreviousEvents,

        /// <summary>
        /// Q21 - QBP - Get person demographics.
        /// </summary>
        QbpGetPersonDemographics,

        /// <summary>
        /// Q22 - QBP - Find candidates.
        /// </summary>
        QbpFindCandidates,

        /// <summary>
        /// Q23 - QBP - Get corresponding identifiers.
        /// </summary>
        QbpGetCorrespondingIdentifiers,

        /// <summary>
        /// Q24 - QBP - Allocate identifiers.
        /// </summary>
        QbpAllocateIdentifiers,

        /// <summary>
        /// Q25 - QBP - Personnel Information by Segment Query.
        /// </summary>
        QbpPersonnelInformationBySegmentQuery,

        /// <summary>
        /// Q26 - ROR - Pharmacy/treatment order response.
        /// </summary>
        RorPharmacyTreatmentOrderResponse,

        /// <summary>
        /// Q27 - RAR - Pharmacy/treatment administration information.
        /// </summary>
        RarPharmacyTreatmentAdministrationInformation,

        /// <summary>
        /// Q28 - RDR - Pharmacy/treatment dispense information.
        /// </summary>
        RdrPharmacyTreatmentDispenseInformation,

        /// <summary>
        /// Q29 - RER - Pharmacy/treatment encoded order information.
        /// </summary>
        RerPharmacyTreatmentEncodedOrderInformation,

        /// <summary>
        /// Q30 - RGR - Pharmacy/treatment dose information.
        /// </summary>
        RgrPharmacyTreatmentDoseInformation,

        /// <summary>
        /// Q31 - QBP Query Dispense history.
        /// </summary>
        QbpQueryDispenseHistory,

        /// <summary>
        /// Q32 - Find Candidates including Visit Information.
        /// </summary>
        FindCandidatesIncludingVisitInformation,

        /// <summary>
        /// R01 - ORU/ACK - Unsolicited transmission of an observation message.
        /// </summary>
        OruAckUnsolicitedTransmissionOfObservation,

        /// <summary>
        /// R02 - QRY - Query for results of observation.
        /// </summary>
        QryQueryForResultsOfObservation,

        /// <summary>
        /// R04 - ORF - Response to query; transmission of requested observation.
        /// </summary>
        OrfResponseToQueryTransmissionOfRequestedObservation,

        /// <summary>
        /// R21 - OUL - Unsolicited laboratory observation.
        /// </summary>
        OulUnsolicitedLaboratoryObservation,

        /// <summary>
        /// R22 - OUL - Unsolicited Specimen Oriented Observation Message.
        /// </summary>
        OulUnsolicitedSpecimenOrientedObservation,

        /// <summary>
        /// R23 - OUL - Unsolicited Specimen Container Oriented Observation Message.
        /// </summary>
        OulUnsolicitedSpecimenContainerOrientedObservation,

        /// <summary>
        /// R24 - OUL - Unsolicited Order Oriented Observation Message.
        /// </summary>
        OulUnsolicitedOrderOrientedObservation,

        /// <summary>
        /// R25 - OPU - Unsolicited Population/Location-Based Laboratory Observation Message.
        /// </summary>
        OpuUnsolicitedPopulationLocationBasedLabObservation,

        /// <summary>
        /// R26 - OSM - Unsolicited Specimen Shipment Manifest Message.
        /// </summary>
        OsmUnsolicitedSpecimenShipmentManifest,

        /// <summary>
        /// R30 - ORU - Unsolicited Point-Of-Care Observation Message Without Existing Order - Place An Order.
        /// </summary>
        OruUnsolicitedPointOfCareObservationWithoutExistingOrder,

        /// <summary>
        /// R31 - ORU - Unsolicited New Point-Of-Care Observation Message - Search For An Order.
        /// </summary>
        OruUnsolicitedNewPointOfCareObservationSearchForOrder,

        /// <summary>
        /// R32 - ORU - Unsolicited Pre-Ordered Point-Of-Care Observation.
        /// </summary>
        OruUnsolicitedPreOrderedPointOfCareObservation,

        /// <summary>
        /// R33 - ORA - Observation Report Acknowledgement.
        /// </summary>
        OraObservationReportAcknowledgement,

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
        /// S27 - SIU/ACK - Broadcast Notification of Scheduled Appointments.
        /// </summary>
        SiuAckBroadcastScheduledAppointments,

        /// <summary>
        /// S28 - SLR/SLS - Request new sterilization lot.
        /// </summary>
        SlrSlsRequestNewSterilizationLot,

        /// <summary>
        /// S29 - SLR/SLS - Request Sterilization lot deletion.
        /// </summary>
        SlrSlsRequestSterilizationLotDeletion,

        /// <summary>
        /// S30 - STI/STS - Request item.
        /// </summary>
        StiStsRequestItem,

        /// <summary>
        /// S31 - SDR/SDS - Request anti-microbial device data.
        /// </summary>
        SdrSdsRequestAntiMicrobialDeviceData,

        /// <summary>
        /// S32 - SMD/SMS - Request anti-microbial device cycle data.
        /// </summary>
        SmdSmsRequestAntiMicrobialDeviceCycleData,

        /// <summary>
        /// S33 - STC/ACK - Notification of sterilization configuration.
        /// </summary>
        StcAckNotifySterilizationConfiguration,

        /// <summary>
        /// S34 - SLN/ACK - Notification of sterilization lot.
        /// </summary>
        SlnAckNotifySterilizationLot,

        /// <summary>
        /// S35 - SLN/ACK - Notification of sterilization lot deletion.
        /// </summary>
        SlnAckNotifySterilizationLotDeletion,

        /// <summary>
        /// S36 - SDN/ACK - Notification of anti-microbial device data.
        /// </summary>
        SdnAckNotifyAntiMicrobialDeviceData,

        /// <summary>
        /// S37 - SCN/ACK - Notification of anti-microbial device cycle data.
        /// </summary>
        ScnAckNotifyAntiMicrobialDeviceCycleData,

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
        /// U01 - ESU/ACK - Automated equipment status update.
        /// </summary>
        EsuAckAutomatedEquipmentStatusUpdate,

        /// <summary>
        /// U02 - ESR/ACK - Automated equipment status request.
        /// </summary>
        EsrAckAutomatedEquipmentStatusRequest,

        /// <summary>
        /// U03 - SSU/ACK - Specimen status update.
        /// </summary>
        SsuAckSpecimenStatusUpdate,

        /// <summary>
        /// U04 - SSR/ACK - specimen status request.
        /// </summary>
        SsrAckSpecimenStatusRequest,

        /// <summary>
        /// U05 - INU/ACK  - Automated equipment inventory update.
        /// </summary>
        InuAckAutomatedEquipmentInventoryUpdate,

        /// <summary>
        /// U06 - INR/ACK - Automated equipment inventory request.
        /// </summary>
        InrAckAutomatedEquipmentInventoryRequest,

        /// <summary>
        /// U07 - EAC/ACK - Automated equipment command.
        /// </summary>
        EacAckAutomatedEquipmentCommand,

        /// <summary>
        /// U08 - EAR/ACK - Automated equipment response.
        /// </summary>
        EarAckAutomatedEquipmentResponse,

        /// <summary>
        /// U09 - EAN/ACK - Automated equipment notification.
        /// </summary>
        EanAckAutomatedEquipment,

        /// <summary>
        /// U10 - TCU/ACK - Automated equipment test code settings update.
        /// </summary>
        TcuAckAutomatedEquipmentTestCodeSettingsUpdate,

        /// <summary>
        /// U11 - TCR/ACK - Automated equipment test code settings request.
        /// </summary>
        TcrAckAutomatedEquipmentTestCodeSettingsRequest,

        /// <summary>
        /// U12 - LSU/ACK - Automated equipment log/service update.
        /// </summary>
        LsuAckAutomatedEquipmentLogServiceUpdate,

        /// <summary>
        /// U13 - LSR/ACK - Automated equipment log/service request.
        /// </summary>
        LsrAckAutomatedEquipmentLogServiceRequest,

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
        QrfWaveformResultResponseToQuery
    }
}
