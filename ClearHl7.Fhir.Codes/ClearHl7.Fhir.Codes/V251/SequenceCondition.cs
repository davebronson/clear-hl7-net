using System;

namespace ClearHl7.Fhir.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0524 - Sequence Condition.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0524</remarks>
    public enum SequenceCondition
    {
        /// <summary>
        /// C - Repeating cycle of orders.
        /// </summary>
        RepeatingCycleOfOrders,
        
        /// <summary>
        /// R - Reserved for possible future use.
        /// </summary>
        ReservedForPossibleFutureUse,
        
        /// <summary>
        /// S - Sequence conditions.
        /// </summary>
        SequenceConditions
    }
}