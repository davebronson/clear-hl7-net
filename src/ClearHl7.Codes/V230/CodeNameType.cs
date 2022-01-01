namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0200 - Name Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0200</remarks>
    public enum CodeNameType
    {
        /// <summary>
        /// A - Assigned.
        /// </summary>
        Assigned,

        /// <summary>
        /// C - Adopted Name.
        /// </summary>
        AdoptedName,

        /// <summary>
        /// D - Customary Name.
        /// </summary>
        CustomaryName,

        /// <summary>
        /// L - Official Registry Name.
        /// </summary>
        OfficialRegistryName,

        /// <summary>
        /// M - Maiden Name.
        /// </summary>
        MaidenName,

        /// <summary>
        /// O - Other.
        /// </summary>
        Other
    }
}
