namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0119 - Order Control Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0119</remarks>
    public enum CodeOrderControlCodes
    {
        /// <summary>
        /// AF - Order/service refill request approval.
        /// </summary>
        OrderServiceRefillRequestApproval,

        /// <summary>
        /// CA - Cancel order/service request.
        /// </summary>
        CancelOrderServiceRequest,

        /// <summary>
        /// CH - Child order/service.
        /// </summary>
        ChildOrderService,

        /// <summary>
        /// CN - Combined result.
        /// </summary>
        CombinedResult,

        /// <summary>
        /// CR - Canceled as requested.
        /// </summary>
        CanceledAsRequested,

        /// <summary>
        /// DC - Discontinue order/service request.
        /// </summary>
        DiscontinueOrderServiceRequest,

        /// <summary>
        /// DE - Data errors.
        /// </summary>
        DataErrors,

        /// <summary>
        /// DF - Order/service refill request denied.
        /// </summary>
        OrderServiceRefillRequestDenied,

        /// <summary>
        /// DR - Discontinued as requested.
        /// </summary>
        DiscontinuedAsRequested,

        /// <summary>
        /// FU - Order/service refilled, unsolicited.
        /// </summary>
        OrderServiceRefilledUnsolicited,

        /// <summary>
        /// HD - Hold order request.
        /// </summary>
        HoldOrderRequest,

        /// <summary>
        /// HR - On hold as requested.
        /// </summary>
        OnHoldAsRequested,

        /// <summary>
        /// NA - Number assigned.
        /// </summary>
        NumberAssigned,

        /// <summary>
        /// NW - New order/service.
        /// </summary>
        NewOrderService,

        /// <summary>
        /// OC - Order/service canceled.
        /// </summary>
        OrderServiceCanceled,

        /// <summary>
        /// OD - Order/service discontinued.
        /// </summary>
        OrderServiceDiscontinued,

        /// <summary>
        /// OE - Order/service released.
        /// </summary>
        OrderServiceReleased,

        /// <summary>
        /// OF - Order/service refilled as requested.
        /// </summary>
        OrderServiceRefilledAsRequested,

        /// <summary>
        /// OH - Order/service held.
        /// </summary>
        OrderServiceHeld,

        /// <summary>
        /// OK - Order/service accepted OK.
        /// </summary>
        OrderServiceAcceptedOk,

        /// <summary>
        /// OR - Released as requested.
        /// </summary>
        ReleasedAsRequested,

        /// <summary>
        /// PA - Parent order/service.
        /// </summary>
        ParentOrderService,

        /// <summary>
        /// RE - Observations/Performed Service to follow.
        /// </summary>
        ObservationsPerformedServiceToFollow,

        /// <summary>
        /// RF - Refill order/service request.
        /// </summary>
        RefillOrderServiceRequest,

        /// <summary>
        /// RL - Release previous hold.
        /// </summary>
        ReleasePreviousHold,

        /// <summary>
        /// RO - Replacement order.
        /// </summary>
        ReplacementOrder,

        /// <summary>
        /// RP - Order/service replace request.
        /// </summary>
        OrderServiceReplaceRequest,

        /// <summary>
        /// RQ - Replaced as requested.
        /// </summary>
        ReplacedAsRequested,

        /// <summary>
        /// RR - Request received.
        /// </summary>
        RequestReceived,

        /// <summary>
        /// RU - Replaced unsolicited.
        /// </summary>
        ReplacedUnsolicited,

        /// <summary>
        /// SC - Status changed.
        /// </summary>
        StatusChanged,

        /// <summary>
        /// SN - Send order/service number.
        /// </summary>
        SendOrderServiceNumber,

        /// <summary>
        /// SR - Response to send order/service status request.
        /// </summary>
        ResponseToSendOrderServiceStatusRequest,

        /// <summary>
        /// SS - Send order/service status request.
        /// </summary>
        SendOrderServiceStatusRequest,

        /// <summary>
        /// UA - Unable to accept order/service.
        /// </summary>
        UnableToAcceptOrderService,

        /// <summary>
        /// UC - Unable to cancel.
        /// </summary>
        UnableToCancel,

        /// <summary>
        /// UD - Unable to discontinue.
        /// </summary>
        UnableToDiscontinue,

        /// <summary>
        /// UF - Unable to refill.
        /// </summary>
        UnableToRefill,

        /// <summary>
        /// UH - Unable to put on hold.
        /// </summary>
        UnableToPutOnHold,

        /// <summary>
        /// UM - Unable to replace.
        /// </summary>
        UnableToReplace,

        /// <summary>
        /// UR - Unable to release.
        /// </summary>
        UnableToRelease,

        /// <summary>
        /// UX - Unable to change.
        /// </summary>
        UnableToChange,

        /// <summary>
        /// XO - Change order/service request.
        /// </summary>
        ChangeOrderServiceRequest,

        /// <summary>
        /// XR - Changed as requested.
        /// </summary>
        ChangedAsRequested,

        /// <summary>
        /// XX - Order/service changed, unsol.
        /// </summary>
        OrderServiceChangedUnsol
    }
}
