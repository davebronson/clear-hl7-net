using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0187 - Provider Billing.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0187</remarks>
    public enum ProviderBilling
    {
        /// <summary>
        /// I - Institution bills for provider.
        /// </summary>
        InstitutionBillsForProvider,
        
        /// <summary>
        /// P - Provider does own billing.
        /// </summary>
        ProviderDoesOwnBilling
    }
}