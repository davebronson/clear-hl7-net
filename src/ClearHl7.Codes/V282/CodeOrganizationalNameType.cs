namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0204 - Organizational Name Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0204</remarks>
    public enum CodeOrganizationalNameType
    {
        /// <summary>
        /// A - Alias name.
        /// </summary>
        AliasName,

        /// <summary>
        /// D - Display name.
        /// </summary>
        DisplayName,

        /// <summary>
        /// L - Legal name.
        /// </summary>
        LegalName,

        /// <summary>
        /// SL - Stock exchange listing name.
        /// </summary>
        StockExchangeListingName
    }
}
