using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0061 - Check Digit Scheme.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0061</remarks>
    public enum CheckDigitScheme
    {
        /// <summary>
        /// BCV - Bank Card Validation Number.
        /// </summary>
        BankCardValidationNumber,
        
        /// <summary>
        /// ISO - ISO 7064: 1983.
        /// </summary>
        Iso70641983,
        
        /// <summary>
        /// M10 - Mod 10 algorithm.
        /// </summary>
        Mod10Algorithm,
        
        /// <summary>
        /// M11 - Mod 11 algorithm.
        /// </summary>
        Mod11Algorithm,
        
        /// <summary>
        /// NPI - Check digit algorithm in the US National Provider Identifier.
        /// </summary>
        CheckDigitInTheNationalProviderIdentifier
    }
}