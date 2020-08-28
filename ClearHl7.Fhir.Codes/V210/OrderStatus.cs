using System;

namespace ClearHl7.Fhir.Codes.V210
{
    /// <summary>
    /// HL7 Version 2 Table 0038 - Order Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0038</remarks>
    public enum OrderStatus
    {
        /// <summary>
        /// CA - Order was canceled.
        /// </summary>
        OrderWasCanceled,
        
        /// <summary>
        /// CM - Order is completed.
        /// </summary>
        OrderIsCompleted,
        
        /// <summary>
        /// DC - Order was discontinued.
        /// </summary>
        OrderWasDiscontinued,
        
        /// <summary>
        /// ER - Error, order not found.
        /// </summary>
        ErrorOrderNotFound,
        
        /// <summary>
        /// HD - Order is on hold.
        /// </summary>
        OrderIsOnHold,
        
        /// <summary>
        /// IP - In process, unspecified.
        /// </summary>
        InProcessUnspecified,
        
        /// <summary>
        /// SC - In process, scheduled.
        /// </summary>
        InProcessScheduled
    }
}