namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0355 - Primary Key Value Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0355</remarks>
    public enum CodePrimaryKeyValueType
    {
        /// <summary>
        /// CE - Coded element.
        /// </summary>
        CodedElement,

        /// <summary>
        /// CWE - Coded with Exceptions.
        /// </summary>
        CodedWithExceptions,

        /// <summary>
        /// PL - Person location.
        /// </summary>
        PersonLocation
    }
}
