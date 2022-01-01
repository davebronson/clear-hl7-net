namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0268 - Override.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0268</remarks>
    public enum CodeOverride
    {
        /// <summary>
        /// A - Override allowed.
        /// </summary>
        OverrideAllowed,

        /// <summary>
        /// R - Override required.
        /// </summary>
        OverrideRequired,

        /// <summary>
        /// X - Override not allowed.
        /// </summary>
        OverrideNotAllowed
    }
}
