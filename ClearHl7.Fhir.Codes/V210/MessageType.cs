namespace ClearHl7.Fhir.Codes.V210
{
    /// <summary>
    /// HL7 Version 2 Table 0076 - Message Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0076</remarks>
    public enum MessageType
    {
        /// <summary>
        /// ACK - General acknowledgment message.
        /// </summary>
        GeneralAcknowledgment,
        
        /// <summary>
        /// ARD - Ancillary RPT (display) (for backward compatibility only).
        /// </summary>
        AncillaryRptDeprecated,
        
        /// <summary>
        /// BAR - Add/change billing account.
        /// </summary>
        AddChangeBillingAccount,
        
        /// <summary>
        /// DSR - Display response.
        /// </summary>
        DisplayResponseDeprecated,
        
        /// <summary>
        /// MCF - Delayed Acknowledgment (Retained for backward compatibility only).
        /// </summary>
        DelayedAcknowledgmentDeprecated,
        
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
        /// UDM - Unsolicited display update message.
        /// </summary>
        UnsolicitedDisplayUpdateMessage
    }
}