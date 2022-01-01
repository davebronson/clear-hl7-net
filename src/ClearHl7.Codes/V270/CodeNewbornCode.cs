namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0425 - Newborn Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0425</remarks>
    public enum CodeNewbornCode
    {
        /// <summary>
        /// 1 - Born in facility.
        /// </summary>
        BornInFacility,

        /// <summary>
        /// 2 - Transfer in.
        /// </summary>
        TransferIn,

        /// <summary>
        /// 3 - Born en route.
        /// </summary>
        BornEnRoute,

        /// <summary>
        /// 4 - Other.
        /// </summary>
        Other,

        /// <summary>
        /// 5 - Born at home.
        /// </summary>
        BornAtHome
    }
}
