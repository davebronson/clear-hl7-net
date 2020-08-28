using System;

namespace ClearHl7.Fhir.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0017 - Transaction Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0017</remarks>
    public enum TransactionType
    {
        /// <summary>
        /// AJ - Adjustment.
        /// </summary>
        Adjustment,
        
        /// <summary>
        /// CD - Credit.
        /// </summary>
        Credit,
        
        /// <summary>
        /// CG - Charge.
        /// </summary>
        Charge,
        
        /// <summary>
        /// CO - Co-payment.
        /// </summary>
        CoPayment,
        
        /// <summary>
        /// PY - Payment.
        /// </summary>
        Payment
    }
}