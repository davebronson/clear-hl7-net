using System;

namespace ClearHl7.Fhir.Codes.V220
{
    /// <summary>
    /// HL7 Version 2 Table 0003 - Event Type Code.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0003</remarks>
    public enum EventTypeCode
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
        OrfResponseToQueryTransmissionOfRequestedObservation
    }
}