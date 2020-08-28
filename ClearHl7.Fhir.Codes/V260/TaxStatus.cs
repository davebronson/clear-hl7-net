using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0572 - Tax Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0572</remarks>
    public enum TaxStatus
    {
        /// <summary>
        /// RVAT - Registered in VAT register.
        /// </summary>
        RegisteredInVatRegister,
        
        /// <summary>
        /// UVAT - Unregistered in VAT register.
        /// </summary>
        UnregisteredInVatRegister
    }
}