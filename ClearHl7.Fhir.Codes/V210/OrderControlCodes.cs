using System;

namespace ClearHl7.Fhir.Codes.V210
{
    /// <summary>
    /// HL7 Version 2 Table 0119 - Order Control Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0119</remarks>
    public enum OrderControlCodes
    {
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
        /// DC - Discontinue order/service request.
        /// </summary>
        DiscontinueOrderServiceRequest,
        
        /// <summary>
        /// DE - Data errors.
        /// </summary>
        DataErrors,
        
        /// <summary>
        /// DR - Discontinued as requested.
        /// </summary>
        DiscontinuedAsRequested,
        
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
        /// OD - Order/service discontinued.
        /// </summary>
        OrderServiceDiscontinued,
        
        /// <summary>
        /// OK - Order/service accepted  OK.
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
        /// RO - Replacement order.
        /// </summary>
        ReplacementOrder,
        
        /// <summary>
        /// RP - Order/service replace request.
        /// </summary>
        OrderServiceReplaceRequest,
        
        /// <summary>
        /// RR - Request received.
        /// </summary>
        RequestReceived,
        
        /// <summary>
        /// RU - Replaced unsolicited.
        /// </summary>
        ReplacedUnsolicited,
        
        /// <summary>
        /// SN - Send order/service number.
        /// </summary>
        SendOrderServiceNumber,
        
        /// <summary>
        /// SS - Send order/service status request.
        /// </summary>
        SendOrderServiceStatusRequest,
        
        /// <summary>
        /// UD - Unable to discontinue.
        /// </summary>
        UnableToDiscontinue,
        
        /// <summary>
        /// UH - Unable to put on hold.
        /// </summary>
        UnableToPutOnHold,
        
        /// <summary>
        /// UR - Unable to release.
        /// </summary>
        UnableToRelease,
        
        /// <summary>
        /// UX - Unable to change.
        /// </summary>
        UnableToChange,
        
        /// <summary>
        /// XR - Changed as requested.
        /// </summary>
        ChangedAsRequested,
        
        /// <summary>
        /// XX - Order/service changed, unsol..
        /// </summary>
        OrderServiceChangedUnsol
    }
}