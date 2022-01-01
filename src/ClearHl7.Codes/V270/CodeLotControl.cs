namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0659 - Lot Control.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0659</remarks>
    public enum CodeLotControl
    {
        /// <summary>
        /// 1 - OR Mode Without Operator.
        /// </summary>
        OrModeWithoutOperator,

        /// <summary>
        /// 2 - OR Mode with Operator.
        /// </summary>
        OrModeWithOperator,

        /// <summary>
        /// 3 - CPD Mode Without Operator.
        /// </summary>
        CpdModeWithoutOperator,

        /// <summary>
        /// 4 - CPD Mode With Operator.
        /// </summary>
        CpdModeWithOperator,

        /// <summary>
        /// 5 - Offline Mode.
        /// </summary>
        OfflineMode
    }
}
