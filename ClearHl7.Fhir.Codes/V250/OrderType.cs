using System;

namespace ClearHl7.Fhir.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0482 - Order Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0482</remarks>
    public enum OrderType
    {
        /// <summary>
        /// I - Inpatient Order.
        /// </summary>
        InpatientOrder,
        
        /// <summary>
        /// O - Outpatient Order.
        /// </summary>
        OutpatientOrder
    }
}