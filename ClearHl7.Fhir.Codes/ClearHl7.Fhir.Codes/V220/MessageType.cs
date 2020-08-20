using System;

namespace ClearHl7.Fhir.Codes.V220
{
    /// <summary>
    /// HL7 Version 2 Table 0076 - Message Type.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0076</remarks>
    public enum MessageType
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
        /// DFT - Detail financial transactions.
        /// </summary>
        DetailFinancialTransactions,
        
        /// <summary>
        /// DSR - Display response.
        /// </summary>
        DisplayResponseDeprecated,
        
        /// <summary>
        /// MCF - Delayed Acknowledgment (Retained for backward compatibility only).
        /// </summary>
        DelayedAcknowledgmentDeprecated,
        
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
        /// UDM - Unsolicited display update message.
        /// </summary>
        UnsolicitedDisplayUpdateMessage
    }
}