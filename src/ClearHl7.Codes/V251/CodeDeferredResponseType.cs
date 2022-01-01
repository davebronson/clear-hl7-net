namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0107 - Deferred Response Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0107</remarks>
    public enum CodeDeferredResponseType
    {
        /// <summary>
        /// B - Before the Date/Time specified.
        /// </summary>
        BeforeTheDateTimeSpecified,

        /// <summary>
        /// L - Later than the Date/Time specified.
        /// </summary>
        LaterThanTheDateTimeSpecified
    }
}
