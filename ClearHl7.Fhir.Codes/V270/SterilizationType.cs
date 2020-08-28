using System;

namespace ClearHl7.Fhir.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0806 - Sterilization Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0806</remarks>
    public enum SterilizationType
    {
        /// <summary>
        /// EOG - Ethylene Oxide Gas.
        /// </summary>
        EthyleneOxideGas,
        
        /// <summary>
        /// PCA - Peracetic acid.
        /// </summary>
        PeraceticAcid,
        
        /// <summary>
        /// STM - Steam.
        /// </summary>
        Steam
    }
}