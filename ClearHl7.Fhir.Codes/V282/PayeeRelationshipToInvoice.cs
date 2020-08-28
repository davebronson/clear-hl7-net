using System;

namespace ClearHl7.Fhir.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0558 - Payee Relationship To Invoice.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0558</remarks>
    public enum PayeeRelationshipToInvoice
    {
        /// <summary>
        /// FM - Family Member.
        /// </summary>
        FamilyMember,
        
        /// <summary>
        /// GT - Guarantor.
        /// </summary>
        Guarantor,
        
        /// <summary>
        /// PT - Patient.
        /// </summary>
        Patient,
        
        /// <summary>
        /// SB - Subscriber.
        /// </summary>
        Subscriber
    }
}