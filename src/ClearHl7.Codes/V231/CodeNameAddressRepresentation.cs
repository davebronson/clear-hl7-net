namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 4000 - Name/Address Representation.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/4000</remarks>
    public enum CodeNameAddressRepresentation
    {
        /// <summary>
        /// A - Alphabetic (i.e., Default or some single-byte).
        /// </summary>
        Alphabetic,

        /// <summary>
        /// I - Ideographic (i.e., Kanji).
        /// </summary>
        Ideographic,

        /// <summary>
        /// P - Phonetic (i.e., ASCII, Katakana, Hiragana, etc.).
        /// </summary>
        Phonetic
    }
}
