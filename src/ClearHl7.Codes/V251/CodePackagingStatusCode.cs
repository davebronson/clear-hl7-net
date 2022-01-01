namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0469 - Packaging Status Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0469</remarks>
    public enum CodePackagingStatusCode
    {
        /// <summary>
        /// 0 - Not packaged.
        /// </summary>
        NotPackaged,

        /// <summary>
        /// 1 - Packaged service (status indicator N, or no HCPCS code and certain revenue codes).
        /// </summary>
        PackagedService,

        /// <summary>
        /// 2 - Packaged as part of partial hospitalization per diem or daily mental health service per diem.
        /// </summary>
        PackagedAsPartOfPerDiem
    }
}
