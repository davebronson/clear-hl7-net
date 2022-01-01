namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0038 - Order Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0038</remarks>
    public enum CodeOrderStatus
    {
        /// <summary>
        /// A - Some, but not all, results available.
        /// </summary>
        SomeButNotAllResultsAvailable,

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
        /// RP - Order has been replaced.
        /// </summary>
        OrderHasBeenReplaced,

        /// <summary>
        /// SC - In process, scheduled.
        /// </summary>
        InProcessScheduled
    }
}
