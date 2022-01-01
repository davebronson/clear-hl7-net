namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0904 - Security Check Scheme.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0904</remarks>
    public enum CodeSecurityCheckScheme
    {
        /// <summary>
        /// BCV - Bank Card Validation Number.
        /// </summary>
        BankCardValidationNumber,

        /// <summary>
        /// CCS - Credit Card Security code.
        /// </summary>
        CreditCardSecurityCode,

        /// <summary>
        /// VID - Version ID.
        /// </summary>
        VersionId
    }
}
