namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0618 - Protection Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0618</remarks>
    public enum CodeProtectionCode
    {
        /// <summary>
        /// LI - Listed.
        /// </summary>
        Listed,

        /// <summary>
        /// UL - Unlisted (Should not appear in directories).
        /// </summary>
        UnlistedShouldNotAppearInDirectories,

        /// <summary>
        /// UP - Unpublished.
        /// </summary>
        Unpublished
    }
}
