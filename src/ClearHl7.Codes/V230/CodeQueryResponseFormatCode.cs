namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0106 - Query/Response Format Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0106</remarks>
    public enum CodeQueryResponseFormatCode
    {
        /// <summary>
        /// D - Response is in display format.
        /// </summary>
        ResponseIsInDisplayFormat,

        /// <summary>
        /// R - Response is in record-oriented format.
        /// </summary>
        ResponseIsInRecordOrientedFormat,

        /// <summary>
        /// T - Response is in tabular format.
        /// </summary>
        ResponseIsInTabularFormat
    }
}
