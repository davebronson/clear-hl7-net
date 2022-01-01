namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0518 - Override Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0518</remarks>
    public enum CodeOverrideType
    {
        /// <summary>
        /// EQV - Equivalence Override.
        /// </summary>
        EquivalenceOverride,

        /// <summary>
        /// EXTN - Extension Override.
        /// </summary>
        ExtensionOverride,

        /// <summary>
        /// INLV - Interval Override.
        /// </summary>
        IntervalOverride
    }
}
