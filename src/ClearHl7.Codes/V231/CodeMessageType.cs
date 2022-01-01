namespace ClearHl7.Codes.V231
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
        /// ARD - Ancillary RPT (display) (for backward compatibility only).
        /// </summary>
        AncillaryRptDeprecated,

        /// <summary>
        /// BAR - Add/change billing account.
        /// </summary>
        AddChangeBillingAccount,

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
        /// ORF - Query for results of observation.
        /// </summary>
        QueryForResultsOfObservationDeprecated,

        /// <summary>
        /// ORM - Pharmacy/treatment order message.
        /// </summary>
        PharmacyTreatmentOrderDeprecated,

        /// <summary>
        /// ORR - General order response message response to any ORM.
        /// </summary>
        GeneralOrderResponseToAnyOrmDeprecated,

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
        /// QCK - Query general acknowledgment.
        /// </summary>
        QueryGeneralAcknowledgmentDeprecated,

        /// <summary>
        /// QRY - Query, original mode.
        /// </summary>
        QueryOriginalMode,

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
        /// SUR - Summary product experience report.
        /// </summary>
        SummaryProductExperienceReportDeprecated,

        /// <summary>
        /// TBR - Tabular data response.
        /// </summary>
        TabularDataResponseDeprecated,

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
