namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0299 - Encoding.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0299</remarks>
    public enum CodeEncoding
    {
        /// <summary>
        /// A - No encoding - data are displayable ASCII characters.
        /// </summary>
        NoEncoding,

        /// <summary>
        /// Base64 - Encoding as defined by MIME (Multipurpose Internet Mail Extensions) standard RFC 1521. Four consecutive ASCII characters represent three consecutive octets of binary data. Base64 utilizes a 65-character subset of US-ASCII, consisting of both the upper and.
        /// </summary>
        Base64,

        /// <summary>
        /// Hex - Hexadecimal encoding - consecutive pairs of hexadecimal digits represent consecutive single octets.
        /// </summary>
        Hexadecimal
    }
}
