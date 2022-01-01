namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0190 - Address Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0190</remarks>
    public enum CodeAddressType
    {
        /// <summary>
        /// B - Firm/Business.
        /// </summary>
        FirmBusiness,

        /// <summary>
        /// C - Current Or Temporary.
        /// </summary>
        CurrentOrTemporary,

        /// <summary>
        /// F - Country Of Origin.
        /// </summary>
        CountryOfOrigin,

        /// <summary>
        /// H - Home.
        /// </summary>
        Home,

        /// <summary>
        /// M - Mailing.
        /// </summary>
        Mailing,

        /// <summary>
        /// O - Office/Business.
        /// </summary>
        OfficeBusiness,

        /// <summary>
        /// P - Permanent.
        /// </summary>
        Permanent
    }
}
