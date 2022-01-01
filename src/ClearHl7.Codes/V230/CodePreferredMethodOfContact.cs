namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0185 - Preferred Method Of Contact.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0185</remarks>
    public enum CodePreferredMethodOfContact
    {
        /// <summary>
        /// B - Beeper Number.
        /// </summary>
        BeeperNumber,

        /// <summary>
        /// C - Cellular Phone Number.
        /// </summary>
        CellularPhoneNumber,

        /// <summary>
        /// E - E-Mail Address (for backward compatibility).
        /// </summary>
        EmailAddress,

        /// <summary>
        /// F - FAX Number.
        /// </summary>
        FaxNumber,

        /// <summary>
        /// H - Home Phone Number.
        /// </summary>
        HomePhoneNumber,

        /// <summary>
        /// O - Office Phone Number.
        /// </summary>
        OfficePhoneNumber
    }
}
