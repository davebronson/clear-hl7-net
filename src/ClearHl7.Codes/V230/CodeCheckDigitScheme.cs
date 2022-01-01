namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0061 - Check Digit Scheme.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0061</remarks>
    public enum CodeCheckDigitScheme
    {
        /// <summary>
        /// M10 - Mod 10 algorithm.
        /// </summary>
        Mod10Algorithm,

        /// <summary>
        /// M11 - Mod 11 algorithm.
        /// </summary>
        Mod11Algorithm
    }
}
