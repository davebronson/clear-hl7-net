namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0504 - Sequence Condition Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0504</remarks>
    public enum CodeSequenceConditionCode
    {
        /// <summary>
        /// EE - End related service request(s), end current service request.
        /// </summary>
        EndRelatedEndCurrent,

        /// <summary>
        /// ES - End related service request(s), start current service request.
        /// </summary>
        EndRelatedStartCurrent,

        /// <summary>
        /// SE - Start related service request(s), end current service request.
        /// </summary>
        StartRelatedEndCurrent,

        /// <summary>
        /// SS - Start related service request(s), start current service request.
        /// </summary>
        StartRelatedStartCurrent
    }
}
