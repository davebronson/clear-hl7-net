namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0076 - Message Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0076</remarks>
    public enum CodeMessageType
    {
        /// <summary>
        /// ACK - General acknowledgment message.
        /// </summary>
        GeneralAcknowledgment,

        /// <summary>
        /// ADR - ADT response.
        /// </summary>
        AdtResponseDeprecated,

        /// <summary>
        /// ADT - ADT message.
        /// </summary>
        AdtMessage,

        /// <summary>
        /// BAR - Add/change billing account.
        /// </summary>
        AddChangeBillingAccount,

        /// <summary>
        /// BPS - Blood product dispense status message.
        /// </summary>
        BloodProductDispenseStatus,

        /// <summary>
        /// BRP - Blood product dispense status acknowledgement message.
        /// </summary>
        BloodProductDispenseStatusAcknowledgement,

        /// <summary>
        /// BRT - Blood product transfusion/disposition acknowledgement message.
        /// </summary>
        BloodProductTransfusionDispositionAcknowledgement,

        /// <summary>
        /// BTS - Blood product transfusion/disposition message.
        /// </summary>
        BloodProductTransfusionDisposition,

        /// <summary>
        /// CRM - Clinical study registration message.
        /// </summary>
        ClinicalStudyRegistration,

        /// <summary>
        /// CSU - Unsolicited study data message.
        /// </summary>
        UnsolicitedStudyData,

        /// <summary>
        /// DFT - Detail financial transactions.
        /// </summary>
        DetailFinancialTransactions,

        /// <summary>
        /// DOC - Document response.
        /// </summary>
        DocumentResponseDeprecated,

        /// <summary>
        /// DSR - Display response.
        /// </summary>
        DisplayResponseDeprecated,

        /// <summary>
        /// EAC - Automated equipment command message.
        /// </summary>
        AutomatedEquipmentCommand,

        /// <summary>
        /// EAN - Automated equipment notification message.
        /// </summary>
        AutomatedEquipmentNotification,

        /// <summary>
        /// EAR - Automated equipment response message.
        /// </summary>
        AutomatedEquipmentResponse,

        /// <summary>
        /// EDR - Enhanced display response.
        /// </summary>
        EnhancedDisplayResponseDeprecated,

        /// <summary>
        /// EQQ - Embedded query language query.
        /// </summary>
        EmbeddedQueryLanguageQueryDeprecated,

        /// <summary>
        /// ERP - Event replay response.
        /// </summary>
        EventReplayResponseDeprecated,

        /// <summary>
        /// ESR - Automated equipment status update acknowledgment message.
        /// </summary>
        AutomatedEquipmentStatusUpdateAcknowledgment,

        /// <summary>
        /// ESU - Automated equipment status update message.
        /// </summary>
        AutomatedEquipmentStatusUpdate,

        /// <summary>
        /// INR - Automated equipment inventory request message.
        /// </summary>
        AutomatedEquipmentInventoryRequest,

        /// <summary>
        /// INU - Automated equipment inventory update message.
        /// </summary>
        AutomatedEquipmentInventoryUpdate,

        /// <summary>
        /// LSR - Automated equipment log/service request message.
        /// </summary>
        AutomatedEquipmentLogServiceRequest,

        /// <summary>
        /// LSU - Automated equipment log/service update message.
        /// </summary>
        AutomatedEquipmentLogServiceUpdate,

        /// <summary>
        /// MCF - Delayed Acknowledgment (Retained for backward compatibility only).
        /// </summary>
        DelayedAcknowledgmentDeprecated,

        /// <summary>
        /// MDM - Medical document management.
        /// </summary>
        MedicalDocumentManagement,

        /// <summary>
        /// MFD - Master files delayed application acknowledgment.
        /// </summary>
        MasterFilesDelayedApplicationAcknowledgmentDeprecated,

        /// <summary>
        /// MFK - Master files application acknowledgment.
        /// </summary>
        MasterFilesApplicationAcknowledgment,

        /// <summary>
        /// MFN - Master files notification.
        /// </summary>
        MasterFilesNotification,

        /// <summary>
        /// MFQ - Master files query.
        /// </summary>
        MasterFilesQueryDeprecated,

        /// <summary>
        /// MFR - Master files response.
        /// </summary>
        MasterFilesResponseDeprecated,

        /// <summary>
        /// NMD - Application management data message.
        /// </summary>
        ApplicationManagementData,

        /// <summary>
        /// NMQ - Application management query message.
        /// </summary>
        ApplicationManagementQueryDeprecated,

        /// <summary>
        /// NMR - Application management response message.
        /// </summary>
        ApplicationManagementResponseDeprecated,

        /// <summary>
        /// OMB - Blood product order message.
        /// </summary>
        BloodProductOrder,

        /// <summary>
        /// OMD - Dietary order.
        /// </summary>
        DietaryOrder,

        /// <summary>
        /// OMG - General clinical order message.
        /// </summary>
        GeneralClinicalOrder,

        /// <summary>
        /// OMI - Imaging order.
        /// </summary>
        ImagingOrder,

        /// <summary>
        /// OML - Laboratory order message.
        /// </summary>
        LaboratoryOrder,

        /// <summary>
        /// OMN - Non-stock requisition order message.
        /// </summary>
        NonStockRequisitionOrder,

        /// <summary>
        /// OMP - Pharmacy/treatment order message.
        /// </summary>
        PharmacyTreatmentOrder,

        /// <summary>
        /// OMS - Stock requisition order message.
        /// </summary>
        StockRequisitionOrder,

        /// <summary>
        /// ORB - Blood product order acknowledgement message.
        /// </summary>
        BloodProductOrderAcknowledgement,

        /// <summary>
        /// ORD - Dietary order acknowledgment message.
        /// </summary>
        DietaryOrderAcknowledgment,

        /// <summary>
        /// ORF - Query for results of observation.
        /// </summary>
        QueryForResultsOfObservationDeprecated,

        /// <summary>
        /// ORG - General clinical order acknowledgment message.
        /// </summary>
        GeneralClinicalOrderAcknowledgment,

        /// <summary>
        /// ORI - Imaging order acknowledgement message.
        /// </summary>
        ImagingOrderAcknowledgement,

        /// <summary>
        /// ORL - Laboratory acknowledgment message (unsolicited).
        /// </summary>
        LaboratoryAcknowledgmentUnsolicited,

        /// <summary>
        /// ORM - Pharmacy/treatment order message.
        /// </summary>
        PharmacyTreatmentOrderDeprecated,

        /// <summary>
        /// ORN - Non-stock requisition - General order acknowledgment message.
        /// </summary>
        NonStockRequisitionGeneralOrderAcknowledgment,

        /// <summary>
        /// ORP - Pharmacy/treatment order acknowledgment message.
        /// </summary>
        PharmacyTreatmentOrderAcknowledgment,

        /// <summary>
        /// ORR - General order response message response to any ORM.
        /// </summary>
        GeneralOrderResponseToAnyOrmDeprecated,

        /// <summary>
        /// ORS - Stock requisition - Order acknowledgment message.
        /// </summary>
        StockRequisitionOrderAcknowledgment,

        /// <summary>
        /// ORU - Unsolicited transmission of an observation message.
        /// </summary>
        UnsolicitedTransmissionOfObservation,

        /// <summary>
        /// OSQ - Query response for order status.
        /// </summary>
        QueryResponseForOrderStatusOsqDeprecated,

        /// <summary>
        /// OSR - Query response for order status.
        /// </summary>
        QueryResponseForOrderStatusOsrDeprecated,

        /// <summary>
        /// OUL - Unsolicited laboratory observation message.
        /// </summary>
        UnsolicitedLaboratoryObservation,

        /// <summary>
        /// PEX - Product experience message.
        /// </summary>
        ProductExperience,

        /// <summary>
        /// PGL - Patient goal message.
        /// </summary>
        PatientGoalMessage,

        /// <summary>
        /// PIN - Patient insurance information.
        /// </summary>
        PatientInsuranceInformation,

        /// <summary>
        /// PMU - Add personnel record.
        /// </summary>
        AddPersonnelRecord,

        /// <summary>
        /// PPG - Patient pathway message (goal-oriented).
        /// </summary>
        PatientPathwayGoalOriented,

        /// <summary>
        /// PPP - Patient pathway message (problem-oriented).
        /// </summary>
        PatientPathwayProblemOriented,

        /// <summary>
        /// PPR - Patient problem message.
        /// </summary>
        PatientProblem,

        /// <summary>
        /// PPT - Patient pathway goal-oriented response.
        /// </summary>
        PatientPathwayGoalOrientedResponseDeprecated,

        /// <summary>
        /// PPV - Patient goal response.
        /// </summary>
        PatientGoalResponseDeprecated,

        /// <summary>
        /// PRR - Patient problem response.
        /// </summary>
        PatientProblemResponseDeprecated,

        /// <summary>
        /// PTR - Patient pathway problem-oriented response.
        /// </summary>
        PatientPathwayProblemOrientedResponseDeprecated,

        /// <summary>
        /// QBP - Query by parameter.
        /// </summary>
        QueryByParameter,

        /// <summary>
        /// QCK - Query general acknowledgment.
        /// </summary>
        QueryGeneralAcknowledgmentDeprecated,

        /// <summary>
        /// QCN - Cancel query.
        /// </summary>
        CancelQuery,

        /// <summary>
        /// QRY - Query, original mode.
        /// </summary>
        QueryOriginalMode,

        /// <summary>
        /// QSB - Create subscription.
        /// </summary>
        CreateSubscription,

        /// <summary>
        /// QSX - Cancel subscription/acknowledge message.
        /// </summary>
        CancelSubscriptionAcknowledge,

        /// <summary>
        /// QVR - Query for previous events.
        /// </summary>
        QueryForPreviousEvents,

        /// <summary>
        /// RAR - Pharmacy/treatment administration information.
        /// </summary>
        PharmacyTreatmentAdministrationInfoDeprecated,

        /// <summary>
        /// RAS - Pharmacy/treatment administration message.
        /// </summary>
        PharmacyTreatmentAdministration,

        /// <summary>
        /// RCI - Return clinical information.
        /// </summary>
        ReturnClinicalInformation,

        /// <summary>
        /// RCL - Return clinical list.
        /// </summary>
        ReturnClinicalList,

        /// <summary>
        /// RDE - Pharmacy/treatment encoded order message.
        /// </summary>
        PharmacyTreatmentEncodedOrder,

        /// <summary>
        /// RDR - Pharmacy/treatment dispense information.
        /// </summary>
        PharmacyTreatmentDispenseInfo,

        /// <summary>
        /// RDS - Pharmacy/treatment dispense message.
        /// </summary>
        PharmacyTreatmentDispense,

        /// <summary>
        /// RDY - Display based response.
        /// </summary>
        DisplayBasedResponse,

        /// <summary>
        /// REF - Patient referral.
        /// </summary>
        PatientReferral,

        /// <summary>
        /// RER - Pharmacy/treatment encoded order information.
        /// </summary>
        PharmacyTreatmentEncodedOrderInformationDeprecated,

        /// <summary>
        /// RGR - Pharmacy/treatment dose information.
        /// </summary>
        PharmacyTreatmentDoseInformationDeprecated,

        /// <summary>
        /// RGV - Pharmacy/treatment give message.
        /// </summary>
        PharmacyTreatmentGive,

        /// <summary>
        /// ROR - Pharmacy/treatment order response.
        /// </summary>
        PharmacyTreatmentOrderResponseDeprecated,

        /// <summary>
        /// RPA - Return patient authorization.
        /// </summary>
        ReturnPatientAuthorization,

        /// <summary>
        /// RPI - Return patient information.
        /// </summary>
        ReturnPatientInfo,

        /// <summary>
        /// RPL - Return patient display list.
        /// </summary>
        ReturnPatientDisplayList,

        /// <summary>
        /// RPR - Return patient list.
        /// </summary>
        ReturnPatientList,

        /// <summary>
        /// RQA - Request patient authorization.
        /// </summary>
        RequestPatientAuthorization,

        /// <summary>
        /// RQC - Request clinical information.
        /// </summary>
        RequestClinicalInformation,

        /// <summary>
        /// RQI - Request patient information.
        /// </summary>
        RequestPatientInformation,

        /// <summary>
        /// RQP - Request patient demographics.
        /// </summary>
        RequestPatientDemographics,

        /// <summary>
        /// RQQ - Event replay query.
        /// </summary>
        EventReplayQueryDeprecated,

        /// <summary>
        /// RRA - Pharmacy/treatment administration acknowledgment message.
        /// </summary>
        PharmacyTreatmentAdministrationAcknowledgment,

        /// <summary>
        /// RRD - Pharmacy/treatment dispense acknowledgment message.
        /// </summary>
        PharmacyTreatmentDispenseAcknowledgment,

        /// <summary>
        /// RRE - Pharmacy/treatment encoded order acknowledgment message.
        /// </summary>
        PharmacyTreatmentEncodedOrderAcknowledgment,

        /// <summary>
        /// RRG - Pharmacy/treatment give acknowledgment message.
        /// </summary>
        PharmacyTreatmentGiveAcknowledgment,

        /// <summary>
        /// RRI - Return referral information.
        /// </summary>
        ReturnReferralInfo,

        /// <summary>
        /// RSP - Segment pattern response.
        /// </summary>
        SegmentPatternResponse,

        /// <summary>
        /// RTB - Tabular response.
        /// </summary>
        TabularResponse,

        /// <summary>
        /// SIU - Schedule information unsolicited.
        /// </summary>
        ScheduleInfoUnsolicited,

        /// <summary>
        /// SPQ - Stored procedure request.
        /// </summary>
        StoredProcedureRequestDeprecated,

        /// <summary>
        /// SQM - Schedule query message.
        /// </summary>
        ScheduleQueryMessageDeprecated,

        /// <summary>
        /// SQR - Schedule query response.
        /// </summary>
        ScheduleQueryResponseDeprecated,

        /// <summary>
        /// SRM - Schedule request message.
        /// </summary>
        ScheduleRequestMessage,

        /// <summary>
        /// SRR - Scheduled request response.
        /// </summary>
        ScheduledRequestResponse,

        /// <summary>
        /// SSR - Specimen status request message.
        /// </summary>
        SpecimenStatusRequestMessage,

        /// <summary>
        /// SSU - Specimen status update message.
        /// </summary>
        SpecimenStatusUpdateMessage,

        /// <summary>
        /// SUR - Summary product experience report.
        /// </summary>
        SummaryProductExperienceReportDeprecated,

        /// <summary>
        /// TBR - Tabular data response.
        /// </summary>
        TabularDataResponseDeprecated,

        /// <summary>
        /// TCR - Automated equipment test code settings request message.
        /// </summary>
        AutomatedEquipmentTestCodeSettingsRequest,

        /// <summary>
        /// TCU - Automated equipment test code settings update message.
        /// </summary>
        AutomatedEquipmentTestCodeSettingsUpdate,

        /// <summary>
        /// UDM - Unsolicited display update message.
        /// </summary>
        UnsolicitedDisplayUpdateMessage,

        /// <summary>
        /// VQQ - Virtual table query.
        /// </summary>
        VirtualTableQueryDeprecated,

        /// <summary>
        /// VXQ - Query for vaccination record.
        /// </summary>
        QueryForVaccinationRecordDeprecated,

        /// <summary>
        /// VXR - Vaccination record response.
        /// </summary>
        VaccinationRecordResponseDeprecated,

        /// <summary>
        /// VXU - Unsolicited vaccination record update.
        /// </summary>
        UnsolicitedVaccinationRecordUpdate,

        /// <summary>
        /// VXX - Response for vaccination query with multiple PID matches.
        /// </summary>
        ResponseForVaccinationQueryWithMultiplePidMatchesDeprecated
    }
}
